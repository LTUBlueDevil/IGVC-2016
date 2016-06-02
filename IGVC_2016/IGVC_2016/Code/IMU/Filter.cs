using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class Filter
    {
        double est, Eest, Emea, KG;

        public Filter(double Error)
        {
            Emea = Error;
            Eest = Error;
        }

        public void Update(double mea)
        {
            //Calculate Kalman Gain
            KG = Eest / (Eest + Emea); 

            //estimate next value
            est = est + KG * (mea - est);

            //calulate estimate error
            Eest = (1 - KG) * Eest;

            //write data to file
            var csv = new StringBuilder();

            var first = mea;
            var second = est;
            var newLine = string.Format("{0},{1}{2}", first, second, Environment.NewLine);

            csv.Append(newLine);

            //compare output to Data.csv
            //System.IO.File.AppendAllText("Data1.csv", csv.ToString());
        }

        public double GetVal()
        {
            return Math.Round(est,2);
        }
    }
}
