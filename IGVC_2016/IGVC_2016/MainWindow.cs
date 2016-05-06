using Emgu.CV;
using Emgu.CV.Structure;
using IGVC_2016.Code.DataIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Created By: Vincent Nicolazzo
 * Created On: 12/1/2015
 * Last Edited: 12/1/2015
 * 
 * This class handles all the inputs and oupts for the robot
 */

namespace IGVC_2016
{
    public partial class MainWindow : Form
    {
        IO_Manager data;
        public MainWindow()
        {
            InitializeComponent();
            data = new IO_Manager(this);
        }

        public void UpdateLabel(string message)
        {
            label1.Text = message;
        }

        public void SetLeft_Display(Image<Bgr, Byte> img)
        {
            //might want to grab the image instead of having IO_Manger set the imagebox
            try { Left_Display.Image = img.Resize(Left_Display.Width, Left_Display.Height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR); }
            catch { }
        }

        public void SetRight_Display(Image<Bgr, Byte> img)
        {
            //might want to grab the image instead of having IO_Manger set the imagebox
            try { Right_Display.Image = img.Resize(Right_Display.Width, Right_Display.Height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR); }
            catch { }
        }

        public int GetLidarHeight()
        {
            return LidarDisplay.Height;
        }

        public int GetLidarWidth()
        {
            return LidarDisplay.Width;
        }

        public void DisplayLidarData(Image<Bgr, Byte> display, List<long> scan)
        {
            LidarDisplay.Image = display;
            //LidarScanData.Image = scan;//when "scan" is an Image

            //create image from scan list
            Image<Bgr, Byte> img = new Image<Bgr, Byte>(LidarScanData.Width,LidarScanData.Height,new Bgr(Color.Black));//create black image

            long height = 0;
            long width = 0;

            for (int i = 0; i < scan.Count; i++)
            {
                double ratioH = (double)(scan[i])/scan.Max();
                double ratioW = (double)(i+1)/scan.Count;

                height = (long)(double)(ratioH*LidarScanData.Height);
                width = (long)(double)(ratioW * LidarScanData.Width);

                for(int h=0;h<height;h++)
                {
                    if (h < LidarScanData.Height)
                    {
                        img.Data[h, width, 0] = 0;  //blue
                        img.Data[h, width, 1] = 255;//green
                        img.Data[h, width, 2] = 255;//red
                    }
                }
            }

            LidarScanData.Image = img.Flip(Emgu.CV.CvEnum.FLIP.VERTICAL);

            //Create diference image on LidarChangeIMage (THis needs to change)
            Image<Bgr, Byte> dimg = new Image<Bgr, Byte>(LidarChangeData.Width, LidarChangeData.Height, new Bgr(Color.Black));//create black image
            List<long> dscan = new List<long>();

            height = 0;
            width = 0;

            for (int i = 1; i < scan.Count; i++)
            {
                dscan.Add(scan[i - 1] - scan[i]);
            }

            for (int i = 0; i < dscan.Count; i++)
            {
                double ratioH = (double)(100*dscan[i]) / dscan.Max();
                double ratioW = (double)(i + 1) / dscan.Count;

                height = (long)((double)ratioH * (LidarChangeData.Height/2));
                width = (long)(double)(ratioW * LidarChangeData.Width);

                if (height > 0)
                {

                    for (int h = LidarChangeData.Height / 2; h < height + LidarChangeData.Height / 2; h++)
                    {
                        if (h < LidarChangeData.Height)
                        {
                            dimg.Data[h, width, 0] = 0;  //blue
                            dimg.Data[h, width, 1] = 255;//green
                            dimg.Data[h, width, 2] = 255;//red
                        }
                    }
                }
                else
                {
                    for (int h = LidarChangeData.Height / 2; h > height +LidarChangeData.Height / 2; h--)
                    {
                        if (h > 0)
                        {
                            dimg.Data[h, width, 0] = 0;  //blue
                            dimg.Data[h, width, 1] = 255;//green
                            dimg.Data[h, width, 2] = 255;//red
                        }
                    }
                }
            }

            LidarChangeData.Image = dimg;
        }

        public void DisplayGPSDAta(string data)
        {
            label1.Text = data.ToString();
        }

        public void setLidarStatus(string status, string comPort, int baud)
        {
            LidarSerialButton.Text = status;
            LidarCOM.Text = comPort;
            LidarBaud.Text = baud.ToString();
        }

        public void setGPSData(string NEMA)
        {
            label1.Text = NEMA.ToString();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.ShutDown();
        }

        private void LidarSerialButton_Click(object sender, EventArgs e)
        {
            if (LidarSerialButton.Text == "Open")
            {
                //tell IO_Manager to turn on Lidar
                data.lidarSerial();

                LidarSerialButton.Text = "Close";
            }
            else
            {
                LidarSerialButton.Text = "Open";
            }
        }
    }
}
