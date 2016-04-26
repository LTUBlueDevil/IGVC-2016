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
using Lengario_UDP_Library;

namespace IGVC_2016.Code.DataIO
{
    class IO_Manager
    {
        //Allows the IO_Manager to set objects on the main form
        private MainWindow parent;

        // Create lidar object
        Lidar l;


        //Create Camera Objects
        Camera Right = new Camera(0);
        Camera Left = new Camera(1);

        Thread oThread;

        UDP_Host networkHost;

        public IO_Manager(MainWindow form)
        {
            //use parent variable to change Main Form
            parent = form;

            //setup host
            networkHost = new UDP_Host();
            networkHost.RegisterID(SampleMessage, "POST");
            networkHost.StartServer();
            
            //Create Thread to get data
            ThreadStart thr = new ThreadStart(this.Process);
            oThread = new Thread(thr);
            oThread.Start();

            l = new Lidar("COM4", 115200, parent.DisplayLidarData); 
        }

        public void Process()
        {
            while (oThread.IsAlive)
            {
                parent.SetRight_Display(Right.img);
                parent.SetLeft_Display(Left.img);

                //make sure there is data before displaying

                //check for controller data

            }
           
        }

        public string SampleMessage(string message)
        {
            parent.UpdateLabel(message);
            return null;
        }

        public void ShutDown()
        {
            //Shutdown all Threads
            oThread.Abort();
            Right.Shutdown();
            Left.Shutdown();
            l.Shutdown();
        }
    }
}
