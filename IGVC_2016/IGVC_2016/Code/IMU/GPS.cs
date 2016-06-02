using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class GPS
    {
        public double Lat { get; private set;}
        public double Long { get; private set;}
        public double time { get; private set;}
        public double date { get; private set;}
        public double speed {get; private set;}
        public bool fix { get; private set; }
        public int numSats { get; private set; }
        public double displacement{ get; private set; }//in meters

        Filter newLat, newLong;
        
        private double startLat = 4328;
        private double startLong = 8300;

        public GPS()
        {
            Lat = 0;
            Long = 0;
            time = 0;
            date = 0;
            speed = 0;
            fix = false;
            numSats = 0;

            newLat = new Filter(5);
            newLong = new Filter(5);
        }

        public void Calibrate()
        {
            startLat += 0;
            startLong += 0;
        }

        private void CalcDist()
        {
            double r = 6.371*1000000;//radius of earth in METERS (6.371 million meters)
            double LatRadians = Lat * Math.PI/180;
            double LongRadians = Long * Math.PI/180;
            double StartLatRadians = startLat * Math.PI/180;
            double StartLongRadians = startLong * Math.PI/180;

            displacement = 2* r*Math.Asin(Math.Sqrt(Math.Pow(Math.Sin((LatRadians - StartLatRadians)/2),2)+
                Math.Cos(StartLatRadians)*Math.Cos(LatRadians)*Math.Pow(Math.Sin((LongRadians - StartLongRadians)/2),2)));
        }

        public void Update(string[] buf)
        {
            switch(buf[0])
            {
            case "$GPRMC":
                {
                    if (fix)
                    {
                        speed = double.Parse(buf[7]);
                        time = double.Parse(buf[1]);
                        date = double.Parse(buf[9]);

                        Lat=double.Parse(buf[3]);
                        Long =double.Parse(buf[5]);
                    }

                    break;
                }
            case "$GPGGA":
                {
                    if (double.Parse(buf[6]) != 0)
                        fix = true;
                    else
                        fix = false;

                    if (fix)
                    {
                        numSats = int.Parse(buf[7]);
                        time = double.Parse(buf[1]);

                        Lat=double.Parse(buf[2]);
                        Long=double.Parse(buf[4]);
                    }
                        
                    break;
                }
            }

            CalcDist();
        }

        public string GetStringLat()
        {
            double D = Math.Floor(Lat / 100);
            double M = Math.Floor(Lat) - Math.Floor(D * 100);

            string d = D.ToString();
            string m = M.ToString();
            string s = (Math.Round((Math.Abs(Lat/100) * 3600) % 60,2)).ToString();
   
            return d + (char)176 + " " + m + "' " + s + "\" N";
        }

        public string GetStringLong()
        {
            double D = Math.Floor(Long / 100);
            double M = Math.Floor(Long) - Math.Floor(D * 100);

            string d = D.ToString();
            string m = M.ToString();
            string s = (Math.Round((Math.Abs(Long/100) * 3600) % 60,2)).ToString();

            return d + (char)176 + " " + m + "' " + s + "\" W";
        }
    }
}
