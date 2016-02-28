using Emgu.CV;
using Emgu.CV.Structure;
using IGVC_2016.Code.Lidar_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGVC_2016.Code.DataIO
{
    class IO_Manager
    {
        //Allows the IO_Manager to set objects on the main form
        private MainWindow parent;

        //Create camera captures
        private Capture Left_Camera = null;
        private Capture Right_Camera = null;

        //in the future want something like {private set; public get}
        private Image<Bgr, Byte> Left_Image;
        private Image<Bgr, Byte> Right_Image;

        public IO_Manager(MainWindow form)
        {
            parent = form;

            Left_Camera = new Capture(0);
            Right_Camera = new Capture(0);

            Left_Camera.ImageGrabbed += Left_Camera_ImageGrabbed;
            Right_Camera.ImageGrabbed += Right_Camera_ImageGrabbed;

            Left_Camera.Start();
            Right_Camera.Start();

            // Create lidar object
            Lidar l = new Lidar(); 
        }

        void Right_Camera_ImageGrabbed(object sender, EventArgs e)
        {
            Right_Image = Right_Camera.RetrieveBgrFrame();
            parent.SetRight_Display(Right_Image);
        }

        private void Left_Camera_ImageGrabbed(object sender, EventArgs e)
        {
            Left_Image = Left_Camera.RetrieveBgrFrame();
            parent.SetLeft_Display(Left_Image);
        }

    }
}
