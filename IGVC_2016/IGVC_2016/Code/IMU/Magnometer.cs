using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class Magnometer
    {
        public double X {get; private set;}
        public double Y {get; private set;}
        public double Z {get; private set;}
        public double Heading {get; private set;}

        public Magnometer()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public void Update(string[] buf)
        {
            X = double.Parse(buf[2]);
            Y = double.Parse(buf[4]);
            Z = double.Parse(buf[6]);

            Heading = Math.Round(Math.Atan2(Y, X) * 180 / Math.PI,2);
        }
    }
}
