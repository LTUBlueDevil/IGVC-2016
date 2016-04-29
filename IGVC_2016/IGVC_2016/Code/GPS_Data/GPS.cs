using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGVC_2016.Code.GPS_Data
{
    class GPS
    {
        SerialPort gps = null;
        public string NEMA;

        BackgroundWorker gpsBW = new BackgroundWorker();

        public GPS(string ComPort, int BaudRate)
        {
            gps = new SerialPort(ComPort, BaudRate);

            try
            {
                gps.Open();
                gpsBW.DoWork += this.Process;

                //Run Thread
                gpsBW.RunWorkerAsync();
            }
            catch(Exception e) { MessageBox.Show(e.ToString());}

            //need to setup delegate for using GPS data
        }

        private void Process(object sender, DoWorkEventArgs e)
        {
            while(!gpsBW.CancellationPending)
            {
                NEMA = gps.ReadExisting();
            }
        }

        public void ShutDown()
        {
            if(gpsBW.IsBusy)
                gpsBW.CancelAsync();
        }


    }
}
