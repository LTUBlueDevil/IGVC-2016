using Emgu.CV;
using Emgu.CV.GPU;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGVC_Controller.Code.Modules.Visualizer.LIDAR
{
    public partial class LIDAR_Visualizer_Form : Form
    {
        public LIDAR_Visualizer_Form()
        {
            InitializeComponent();
        }

        public void setLIDARData(List<long> data)
        {
            this.ForwardDistanceLabel.Text = "Forward Distance: " + data[540].ToString();

            Image<Bgr, byte> img = new Image<Bgr, byte>(601, 601);
            for (int i = 5; i <= 30; i += 5)
            {
                img.Draw(new CircleF(new PointF(300, 300), i * 10), new Bgr(Color.Gray), 1);
            }

            img.Draw(new LineSegment2D(new Point(0, 300), new Point(600, 300)), new Bgr(Color.LightGray), 1);
            img.Draw(new LineSegment2D(new Point(300, 0), new Point(300, 600)), new Bgr(Color.LightGray), 1);

            int c = data.Count;

            //for (int i = 1; i < c-1; i++)
            //{
            //    int dis1 = (int)data[i] - (int)data[i - 1];
            //    int dis2 = (int)data[i] - (int)data[i + 1];

            //    int min = dis1;
            //    if (dis2 < dis1)
            //        min = dis2;

            //    if (min > 50)
            //        data[i] = 0;
            //}

            for (int i = 0; i < c; i++)
            {
                double valInMeters = (double)data[i] / 1000.0;
                if (valInMeters == 0 || valInMeters >= 30.0)
                    continue;

                double angle = /*angle ratio*/ ((double)(1080 - i) / (double)c) * /*angle range*/ (135.0 * 2)
                    - /*angle offset*/ 135.0;

                //to radians
                angle = (angle / 180.0) * Math.PI;
                //angle 0degrees = up

                //y in meters
                double yMeters = (Math.Cos(angle) * valInMeters);
                //y in pixels (300 pixels = 30 meters | 10 pixels = 1 meter
                int y = (int)(yMeters * 10.0);

                //adjust y for screen coords (+300y is 0y | 0y is 300y | -300y is 600y
                y = -y + 300;

                //x in meters
                double xMeters = (Math.Sin(angle) * valInMeters);
                //x in pixels (10 pixels = 1 meter)
                int x = (int)(xMeters * 10.0);

                //adjust x for screen coords (-300x is 0x | 0x is 300x | 300x is 600x)
                x = x + 300;

                if (i == 540 + (540 / 2))
                    this.ForwardDistanceLabel.Text = xMeters.ToString() + " : " + yMeters.ToString();

                img.Data[y, x, 0] = 0;//Blue
                img.Data[y, x, 1] = 255;//Green
                img.Data[y, x, 2] = 255;//Red

                y++;
                img.Data[y, x, 0] = 0;//Blue
                img.Data[y, x, 1] = 255;//Green
                img.Data[y, x, 2] = 255;//Red

                y--;
                x++;
                img.Data[y, x, 0] = 0;//Blue
                img.Data[y, x, 1] = 255;//Green
                img.Data[y, x, 2] = 255;//Red

                y++;
                img.Data[y, x, 0] = 0;//Blue
                img.Data[y, x, 1] = 255;//Green
                img.Data[y, x, 2] = 255;//Red
            }

            this.LIDAR_Image.Image = img;
        }

        private void LIDAR_Visualizer_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
