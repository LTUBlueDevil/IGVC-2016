using Emgu.CV;
using Emgu.CV.Structure;
using IGVC_2016.Code.Lidar_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGVC_2016.Code.Camera_Data;
using System.Threading;
//using Lengario_UDP_Library;
using System.Drawing;
using IGVC_2016.Code.GPS_Data;
using IGVC_2016.Code.DataIO.Controller;
using System.IO.Ports;

namespace IGVC_2016.Code.DataIO
{
    class IO_Manager
    {
        //Allows the IO_Manager to set objects on the main form
        private MainWindow parent;

        // Create lidar object
        Lidar l;
        GPS gpsUnit;

        //Create Camera Objects
        Camera Right = new Camera(0);
        Camera Left = new Camera(1);

        SerialPort Arduino;

        Thread oThread;

        Manual controller;

        bool serialPortReady = true;

        //UDP_Host networkHost;

        public IO_Manager(MainWindow form)
        {
            //use parent variable to change Main Form
            parent = form;

            //setup host
            //networkHost = new UDP_Host();
            //networkHost.RegisterID(SampleMessage, "POST");
            //networkHost.StartServer();
            
            //Create Thread to get data
            ThreadStart thr = new ThreadStart(this.Process);
            oThread = new Thread(thr);
            
            try 
            { 
                Arduino = new SerialPort("COM5", 9600);
                Arduino.DataReceived += Arduino_DataReceived;
                Arduino.Open();
            }
            catch { }

            //send function to lidar constructor to assign function to delegate
            l = new Lidar("COM6", 115200, this.DisplayLidarData); 

            if(l.isOpen())
            {
                parent.setLidarStatus("Close","COM5",115200);
            }
            else
            {
                parent.setLidarStatus("Open", "COM5", 115200);
            }

            //Create GPS object
            //gpsUnit = new GPS("COM7", 9600);

            controller = new Manual();
            
            oThread.Start();
        }

        void Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            char temp = (char)Arduino.ReadByte();
            if(temp == 'R')
                serialPortReady = true;
        }

        public void lidarSerial()
        {
            //turn on Lidar
            l.Open();
        }

        public void Process()
        {
            while (oThread.IsAlive)
            {
                parent.SetRight_Display(Right.img);
                parent.SetLeft_Display(Left.img);

                //get controller data
                string command = controller.Task();

                if (command != "" && serialPortReady == true)
                {
                    Arduino.Write(command);
                    serialPortReady = false;
                }
                //Thread.Sleep(100);
                //need to setup delegate for gps
                //parent.setGPSData(gpsUnit.NEMA);
            }
           
        }

        public void DisplayLidarData(List<long> dist)
        {
            //get Lidar data
            List<long> data = new List<long>(dist);
            List<int> xArray = new List<int>();
            List<int> yArray = new List<int>();

            #region Generate LIDAR MAP
            //generate Image here if Lidar Field

            int height = parent.GetLidarHeight();
            int width = parent.GetLidarWidth();

            Image<Bgr, byte> lid_img = new Image<Bgr, byte>(width, height);

            // Create blank image
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    lid_img.Data[h, w, 0] = 0; // B
                    lid_img.Data[h, w, 1] = 0; // G
                    lid_img.Data[h, w, 2] = 0; // R
                }
            }

            //Draw circles
            for (int j = 5; j <= 30; j += 5)
            {
                lid_img.Draw(new CircleF(new PointF(width / 2, height / 2), j * 10), new Bgr(Color.White), 1);
            }

            //Draw Vertiacl and Horizontal Lines
            lid_img.Draw(new LineSegment2D(new Point(width / 2, 0), new Point(width / 2, height)), new Bgr(Color.LightGray), 1);
            lid_img.Draw(new LineSegment2D(new Point(0, height / 2), new Point(width, height / 2)), new Bgr(Color.LightGray), 1);
            #endregion

            // Determines xy coordinates of each point in lidar vision list
            double deg = -45;

            foreach (long valInMeters in data)//iterate through each point in List
            {
                if (valInMeters == 0 || valInMeters >= 10000.0)
                    continue;

                double x_inMeters = (valInMeters / 1000.0 * Math.Cos(deg * Math.PI / 180));
                double y_inMeters = (valInMeters / 1000.0 * Math.Sin(deg * Math.PI / 180));

                //y in pixels (600 pixels = 30 meters | 60 pixels = 1 meter)
                //adjust y for screen coords (+300y is 0y | 0y is 300y | -300y is 600y)
                int y = (int)(-1 * (y_inMeters*3 * 10 * 2) + height / 2);
                yArray.Add((int)y);

                //x in pixels (60 pixels = 1 meter)
                //adjust x for screen coords (-300x is 0x | 0x is 300x | 300x is 600x)
                int x = (int)((x_inMeters*2 * 10 * 3) + width / 2);
                xArray.Add((int)x);
                deg += .25; // inc by step size

                //plot data
                if (y < lid_img.Height && x < lid_img.Width && y > 0 && x > 0)
                {
                    lid_img.Data[y, x, 0] = 0;   // B
                    lid_img.Data[y, x, 1] = 255; // G
                    lid_img.Data[y, x, 2] = 255; // R
                }
            }
            lid_img = FindBarrel(lid_img, xArray, yArray);

            parent.DisplayLidarData(lid_img,dist);
        }

        public Image<Bgr, byte> FindBarrel(Image<Bgr, byte> img, List<int> x, List<int> y)
        {
            double a,b,r;
            int mult = 32;
            //iterate through 
            for (int i = 0; i < x.Count - 2 * mult; i++)
            {
                if ((2 * (x[i] * y[i + 1 * mult] - x[i + 1 * mult] * y[i] - x[i] * y[i + 2 * mult] + x[i + 2 * mult] * y[i] + x[i + 1 * mult] * y[i + 2 * mult] - x[i + 2 * mult] * y[i + 1 * mult])) != 0)
                {
                    //this currently does not work but the equation for a circle is correct
                    a = (x[i] ^ 2 * y[i + 1 * mult] - x[i] ^ 2 * y[i + 2 * mult] - x[i + 1 * mult] ^ 2 * y[i] + x[i + 1 * mult] ^ 2 * y[i + 2 * mult] + x[i + 2 * mult] ^ 2 * y[i] - 
                        x[i + 2 * mult] ^ 2 * y[i + 1 * mult] + y[i] ^ 2 * y[i + 1 * mult] - y[i] ^ 2 * y[i + 2 * mult] - y[i] * y[i + 1 * mult] ^ 2 + y[i] * y[i + 2 * mult] ^ 2 + 
                        y[i + 1 * mult] ^ 2 * y[i + 2 * mult] - y[i + 1 * mult] * y[i + 2 * mult] ^ 2) / (2 * (x[i] * y[i + 1 * mult] - x[i + 1 * mult] * y[i] - x[i] * y[i + 2 * mult] + 
                        x[i + 2 * mult] * y[i] + x[i + 1 * mult] * y[i + 2 * mult] - x[i + 2 * mult] * y[i + 1 * mult]));

                    b = (-x[i] ^ 2 * x[i + 1 * mult] + x[i] ^ 2 * x[i + 2 * mult] + x[i] * x[i + 1 * mult] ^ 2 - x[i] * x[i + 2 * mult] ^ 2 + x[i] * y[i + 1 * mult] ^ 2 - 
                        x[i] * y[i + 2 * mult] ^ 2 - x[i + 1 * mult] ^ 2 * x[i + 2 * mult] + x[i + 1 * mult] * x[i + 2 * mult] ^ 2 - x[i + 1 * mult] * y[i] ^ 2 + 
                        x[i + 1 * mult] * y[i + 2 * mult] ^ 2 + x[i + 2 * mult] * y[i] ^ 2 - x[i + 2 * mult] * y[i + 1 * mult] ^ 2) / (2 * (x[i] * y[i + 1 * mult] - 
                        x[i + 1 * mult] * y[i] - x[i] * y[i + 2 * mult] + x[i + 2 * mult] * y[i] + x[i + 1 * mult] * y[i + 2 * mult] - x[i + 2 * mult] * y[i + 1 * mult]));

                    r = Math.Sqrt(Math.Pow((x[i] - a), 2) + Math.Pow((y[i] - b), 2));
                    if (r < 50)
                        img.Draw(new CircleF(new PointF((float)a, (float)b), (float)r), new Bgr(Color.Red), 1);
                }
            }

            return img;
        }

        public void DisplayGPS()
        {

        }

        public string SampleMessage(string message)
        {
            parent.UpdateLabel(message);
            return null;
        }

        public void ShutDown()
        {
            //Shutdown all Threads
            oThread.Abort();
            Right.Shutdown();
            Left.Shutdown();
            l.Shutdown();
        }
    }
}
