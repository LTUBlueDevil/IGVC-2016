using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD:IGVC_2016/IGVC_2016/Code/DataIO/IO_Manager.cs
using IGVC_2016.Code.Lidar_Data;
using Emgu.CV;
using Emgu.CV.Structure;

/*Created by: Vince Nicolazzo
 * Created on: (Sometime in November 2015)
 * Last edited: 12/1/2015
 * 
 * This will handle all inputs and outputs for the robot
 */
=======
>>>>>>> parent of 289b635... Created IO Manager:IGVC_2016/IGVC_2016/Code/Lidar/Lidar.cs

namespace IGVC_2016.Code.Lidar
{
    class Lidar
    {
<<<<<<< HEAD:IGVC_2016/IGVC_2016/Code/DataIO/IO_Manager.cs
        private Lidar lidr = new Lidar();
        private Capture Left_Camera = null;
        private Capture Right_Camera = null;

        private Image<Bgr, Byte> Left_Image;
        private Image<Bgr, Byte> Right_Image;

        private MainWindow parent;

        public IO_Manager(MainWindow form)
        {
            this.parent = form;

            //Assign Cameras different Threads
            Left_Camera = new Capture(0);
            //Right_Camera = new Capture(1); //when testing I did not have a second camera to assign Capture(1)
            Right_Camera = Left_Camera;//Line is used to test Form

            //Declare Image Capture Event handlers
            Left_Camera.ImageGrabbed += Left_Camera_ImageGrabbed;
            Right_Camera.ImageGrabbed += Right_Camera_ImageGrabbed;

            //Start Image Capture Threads
            Left_Camera.Start();
            Right_Camera.Start();
        }

        void Left_Camera_ImageGrabbed(object sender, EventArgs e)
        {
            Left_Image = Left_Camera.RetrieveBgrFrame();
            this.parent.SetLeft_Display(Left_Image);
        }

        void Right_Camera_ImageGrabbed(object sender, EventArgs e)
        {
            Right_Image = Right_Camera.RetrieveBgrFrame();
            this.parent.SetRight_Display(Right_Image);
        }

        public Image<Bgr, Byte> GetLeft_Image()
        {
            return Left_Image;
        }

        public Image<Bgr, Byte> GetRight_Image()
        {
            return Right_Image;
        }

=======
>>>>>>> parent of 289b635... Created IO Manager:IGVC_2016/IGVC_2016/Code/Lidar/Lidar.cs
    }
}
