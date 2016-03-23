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
 * Last edited: 3/16/2016
 * 
 * When Lidar class is created, a thread will be created to collect 
 * Raw data and save it to a public variable distances
 */
namespace IGVC_2016.Code.Lidar_Data
{
    class Lidar
    {
        //"urg" is the name of the Lidar manufacturer
        SerialPort urg = null;

        public List<long> distances = new List<long>();

        BackgroundWorker lidarBW = new BackgroundWorker();

        //defining
        private int start_step = 0;
        private int end_step = 760;

        public Lidar(string ComPort, int Baudrate)
        {
            urg = new SerialPort(ComPort, Baudrate);
            
            try 
            {
                urg.NewLine = "\n\n";//this is critical
                urg.Open(); 

                //Assign Event Handler this.Process to DoWork
                lidarBW.DoWork += this.Process;

                //Run Thread (this.Porcess)
                lidarBW.RunWorkerAsync();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
           
        }

        private void Process(object sender, DoWorkEventArgs e)
        {
            while(!lidarBW.CancellationPending)
            {
                urg.Write(SCIP_Writer.SCIP2());
                urg.ReadLine();//ignore echo

                urg.Write(SCIP_Writer.MD(start_step, end_step));
                urg.ReadLine();//ignore echo

                string sData = urg.ReadLine();//Raw Scanner data
                long timeStamp = 0;

                for (int i = 0; i < 10; ++i)
                {
                    string receive_data = urg.ReadLine();
                    if(!SCIP_Reader.MD(receive_data,ref timeStamp,ref distances))
                    {
                        break;
                    }
                    if(distances.Count == 0)
                    {
                        continue;
                    }
                }
            }
        }

        public void Shutdown()
        {
            if(lidarBW.IsBusy)
                lidarBW.CancelAsync();
        }
    }
}
