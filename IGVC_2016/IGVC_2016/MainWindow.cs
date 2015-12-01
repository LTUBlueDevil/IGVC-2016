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

/*This is the main form
 * Created for the 2016 IGVC Robotics team
 * 
 * Last edited: 11/24/15
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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        public void SetRight_Display(Image<Bgr, Byte> img)
        {
            Right_Display.Image = img;
        }

        public void SetLeft_Display(Image<Bgr, Byte> img)
        {
            Left_Display.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LidarVisulizer frm = new LidarVisulizer();
            frm.Show();
        }
    }
}
