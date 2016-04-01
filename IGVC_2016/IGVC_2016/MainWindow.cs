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
            //generate Image here if Lidar Field
            //Luis

            Image<Rgb, byte> lid_img = new Image<Rgb, byte>(LidarDisplay.Width, LidarDisplay.Height);
            int[] x = new int[1080];
            int[] y = new int[1080];
            
            // Determines xy coordinates of each point in lidar vision list
            double deg = -45;
            foreach (long point in dist)
            {
                int i = 0; // tracks steps

                x[i] = lid_img.Width / 2 + Convert.ToInt32(Math.Round(point * Math.Cos(deg))); //
                y[i] = lid_img.Height / 2 - Convert.ToInt32(Math.Round(point * Math.Sin(deg)));
                
                i++;
                deg += 270.00 / 1080.00; // inc by step size
            }

            // Generates Lidar Image
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

            // place dots at lidar points
            for (int d = 0; d < 270; d++)
            {
                lid_img.Data[y[d], x[d], 0] = 255; // B
                lid_img.Data[y[d], x[d], 1] = 255; // G
                lid_img.Data[y[d], x[d], 2] = 255; // R
            }

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.ShutDown();
        }
    }
}
