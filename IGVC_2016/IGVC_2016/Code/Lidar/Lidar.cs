using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGVC_2016.Code.Lidar_Data;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using IGVC_Controller.Code.DataIO;

/*Created by: Vince Nicolazzo
 * Created on: (Sometime in November 2015)
 * Last edited: 2/28/2016
 * 
 * When Lidar class is created, a thread will be created to collect 
 * Raw data and save it to a public variable
 */
namespace IGVC_2016.Code.Lidar_Data
{
    class Lidar
    {
        //"urg" is the name of the Lidar manufacturer
        SerialPort urg = new SerialPort();

        BackgroundWorker lidarBW = new BackgroundWorker();

        //defining
        private int start_step = 0;
        private int end_step = 1080;

        public Lidar()
        {
            urg.PortName = "COM5";
            urg.BaudRate = 115200;
            
            try { urg.Open(); }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            //Assign Event Handler this.Process to DoWork
            lidarBW.DoWork += this.Process;

            //Run Thread (this.Porcess)
            lidarBW.RunWorkerAsync();
        }

        public void Process(object sender, DoWorkEventArgs e)
        {
            urg.Write(SCIP_Writer.MD(start_step,end_step,1 ,0,1));//Make 1 scan
            urg.ReadLine();//ignore echo

            string sData = urg.ReadLine();//Raw Scanner data
            long timeStamp = 0;

            //Possibly save distances to a public variable?
            List<long> distances = new List<long>();
            SCIP_Reader.MD(sData, ref timeStamp, ref distances);
        }
    }
}
