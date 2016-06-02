using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class IMU
    {
        Accelerometer accel;
        Magnometer mag;
        Gyroscope gyro;
        GPS g;

        Kalman K;

        public IMU(int dt)
        {
            accel = new Accelerometer();
            mag = new Magnometer();
            gyro = new Gyroscope();
            g = new GPS();

            K = new Kalman(dt);
        }

        public void CalGPS()
        {
            g.Calibrate();
        }

        public void Parse(string str)
        {
            string[] buf = str.Split(',');

            switch (buf[0])
            {
            case "$GPRMC":
                {
                    g.Update(buf);
                    break;
                }
            case "$GPGGA":
                {
                    g.Update(buf);
                    break;
                }
            case "$ACCEL":
                {
                    accel.Update(buf);
                    break;
                }
            case "$GYRO":
                {
                    gyro.Update(buf);
                    break;
                }
            case "$MAG":
                {
                    mag.Update(buf);
                    break;
                }
            default:
                {
                    //Garbage data
                    break;
                }
            }

            K.Update(mag, gyro, accel, g);
            //craete function to get estimated data
        }

        public string[] GPS()
        {
            //return GPS data in a string array
            string[] buf = new string[5];

            buf[0] = g.GetStringLat().ToString();
            buf[1] = g.GetStringLong().ToString();
            buf[2] = g.time.ToString();
            buf[3] = g.date.ToString();
            buf[4] = g.displacement.ToString();

            return buf;
        }

        public double[] Accel()
        {
            //return accelerometer data in a string array
            double[] buf = new double[3];

            buf[0] = accel.X;
            buf[1] = accel.Y;
            buf[2] = accel.Z;

            return buf;
        }

        public double[] Mag()
        {
            //return accelerometer data in a string array
            double[] buf = new double[3];

            buf[0] = mag.X;
            buf[1] = mag.Y;
            buf[2] = mag.Z;

            return buf;
        }

        public double[] Gyro()
        {
            //return gyroscope data in a string array
            double[] buf = new double[3];

            buf[0] = gyro.X;
            buf[1] = gyro.Y;
            buf[2] = gyro.Z;

            return buf;
        }

        public double Heading()
        {
            return mag.Heading;
        }
    }
}
