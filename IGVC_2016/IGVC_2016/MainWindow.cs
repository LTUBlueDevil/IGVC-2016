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
            LidarDisplay.Width = 601;
            LidarDisplay.Height = 601;
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

        
        public void DisplayLidarData(List<long> dist)
        {
            //get Lidar data
            List<long> data = new List<long>(dist);

            #region Generate LIDAR MAP
            //generate Image here if Lidar Field

            int height = LidarDisplay.Height;
            int width = LidarDisplay.Width;

            Image<Bgr, byte> lid_img = new Image<Bgr, byte>(width, height);

            // Create blank image
            for (int h = 0; h < LidarDisplay.Height; h++)
            {
                for (int w = 0; w < LidarDisplay.Width; w++)
                {
                    lid_img.Data[h, w, 0] = 0; // B
                    lid_img.Data[h, w, 1] = 0; // G
                    lid_img.Data[h, w, 2] = 0; // R
                }
            }

            //Draw circles
            for(int j= 5; j<=30; j+=5)
            {
                lid_img.Draw(new CircleF(new PointF(height/2, width/2), j * 10), new Bgr(Color.White), 1);
            }

            //Draw Vertiacl and Horizontal Lines
            lid_img.Draw(new LineSegment2D(new Point(0, width/2), new Point(height, width/2)), new Bgr(Color.LightGray), 1);
            lid_img.Draw(new LineSegment2D(new Point(height/2, 0), new Point(height/2, width)), new Bgr(Color.LightGray), 1);
            #endregion

            // Determines xy coordinates of each point in lidar vision list
            double deg = -45;

            foreach (long valInMeters in data)//iterate through each point in List
            {
                if (valInMeters == 0 || valInMeters >= 30000.0)
                    continue;

                double x_inMeters = (valInMeters/1000.0 * Math.Cos(deg * Math.PI / 180));
                double y_inMeters = (valInMeters/1000.0 * Math.Sin(deg * Math.PI / 180));

                //y in pixels (300 pixels = 30 meters | 10 pixels = 1 meter)
                //adjust y for screen coords (+300y is 0y | 0y is 300y | -300y is 600y)
                int y = (int)(-1*(y_inMeters * 10) + 300);

                //x in pixels (10 pixels = 1 meter)
                //adjust x for screen coords (-300x is 0x | 0x is 300x | 300x is 600x)
                int x = (int)((x_inMeters * 10) + 300);

                deg += .25; // inc by step size

                //plot data
                lid_img.Data[y, x, 0] = 0;   // B
                lid_img.Data[y, x, 1] = 255; // G
                lid_img.Data[y, x, 2] = 255; // R
            }

            LidarDisplay.Image = lid_img;
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.ShutDown();
        }
    }
}
