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
            Image<Bgr, byte> img = new Image<Bgr, byte>(LidarDisplay.Width, LidarDisplay.Height);
            for(int i = 5; i <=30; i+=5)
            {
                img.Draw(new CircleF(new PointF(300, 300), i * 10), new Bgr(Color.Gray), 1);
            }

            img.Draw(new LineSegment2D(new Point(0, 300), new Point(600, 300)), new Bgr(Color.LightGray), 1);
            img.Draw(new LineSegment2D(new Point(300, 0), new Point(300, 600)), new Bgr(Color.LightGray), 1);

            //need a delegate to display to form
            //label1.Text = dist.ToArray<long>()[0].ToString();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            data.ShutDown();
        }
    }
}
