using Emgu.CV;
using Emgu.CV.Structure;
using IGVC_2016.Code.Lidar_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGVC_2016.Code.Camera_Data;
using System.Threading;

namespace IGVC_2016.Code.DataIO
{
    class IO_Manager
    {
        //Allows the IO_Manager to set objects on the main form
        private MainWindow parent;

        // Create lidar object
        Lidar l = new Lidar(); 

        //Create Camera Objects
        Camera Right = new Camera(0);
        Camera Left = new Camera(1);

        Thread oThread;
        public IO_Manager(MainWindow form)
        {
            //use parent variable to change Main Form
            parent = form;

            //Create Thread
            ThreadStart thr = new ThreadStart(this.Process);
            oThread = new Thread(thr);
            oThread.Start();
        }

        public void Process()
        {
            while (oThread.IsAlive)
            {
                parent.SetRight_Display(Right.img);
                parent.SetLeft_Display(Left.img);
            }
           
        }

        public void ShutDown()
        {
            //Shutdown all Threads
            oThread.Abort();
            Right.Shutdown();
            Left.Shutdown();
        }
    }
}
