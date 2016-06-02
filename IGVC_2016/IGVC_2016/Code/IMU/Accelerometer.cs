using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class Accelerometer
    {
        const int capacity = 5;//how much data will be saved

        Queue<double> qX = new Queue<double>(capacity);
        Queue<double> qY = new Queue<double>(capacity);
        Queue<double> qZ = new Queue<double>(capacity);

        Filter fx, fy, fz;

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        const double g = 1;//g -> m/s^2

        public Accelerometer()
        {
            X = 0;
            Y = 0;
            Z = 0;

            fx = new Filter(56);//56 is from data collected
            fy = new Filter(56);//56 is from data collected
            fz = new Filter(56);//56 is from data collected
        }

        public void Update(string[] buf)
        {
            double bufX, bufY, bufZ;

            bufX = double.Parse(buf[2]);
            bufY = double.Parse(buf[4]);
            bufZ = double.Parse(buf[6]);

            fx.Update(bufX);
            fy.Update(bufY);
            fz.Update(bufZ);

            X = bufX;// fx.GetVal() * g;
            Y = bufY;// fy.GetVal() * g;
            Z = bufZ;// fz.GetVal() * g;
        }
    }
}
