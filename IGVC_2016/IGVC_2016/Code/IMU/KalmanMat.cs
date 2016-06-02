using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class KalmanMat
    {
        Matrix A;
        Matrix X;//state matrix
        Matrix P;//process covariance
        Matrix H;
        Matrix R;//Measurement Covariance
        Matrix I;//identity matrix
        Matrix Y;//output matrix

        public KalmanMat(Matrix state)
        {
            X = state;
        }
    }
}
