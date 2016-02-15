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
        

        public MainWindow()
        {
            InitializeComponent();
            IO_Manager data = new IO_Manager(this);
        }

        public void SetLeft_Display(Image<Bgr, Byte> img)
        {
            //might want to grab the image instead of having IO_Manger set the imagebox
            Left_Display.Image = img.Resize(Left_Display.Width,Left_Display.Height,Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
        }

        public void SetRight_Display(Image<Bgr, Byte> img)
        {
            //might want to grab the image instead of having IO_Manger set the imagebox
            Right_Display.Image = img.Resize(Right_Display.Width, Right_Display.Height, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
        }

        
    }
}
