using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace IGVC_2016.Code.Camera_Data
{
    class Camera
    {
        Capture lens = null;

        //Variable that thread will assign data to be referenced 
        //from outside program
        public Image<Bgr, Byte> img;

        public Camera(int num)
        {

            lens = new Capture(num);
            lens.ImageGrabbed += this.Process;

            lens.Start();
        }

        public void Process(object sender, EventArgs e)
        {
            img = lens.RetrieveBgrFrame();
        }

        public void Shutdown()
        {
            lens.Stop();
        }
    }
}
