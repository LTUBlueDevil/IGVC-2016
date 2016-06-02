using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalman_Filter
{
    class Kalman
    {
        const int numStates = 6;//number of states

        double[] state; //state matrix for filter
        double[] stateP;//predicted state matrix

        double[,] A;// A matrix for predicting next state
        double[,] P;// Process covariance matrix
        double[,] P_future;// future Process covariance matrix
        double[,] R;//Measurment covariance matrix
        double[,] K;//Kalman gain matrix
        double[,] H;//identity matrix

        double[] Measurement;//Actual measurement reading

        public Kalman(int dt) 
        {
            A = new double[numStates, numStates];
            P = new double[numStates, numStates];
            R = new double[numStates, numStates];
            H = new double[numStates, numStates];
            Measurement = new double[numStates];

            double delta = (double)dt / 1000;

            //These values represent real world math
            A[0, 0] = 1;
            A[0, 1] = .5 * Math.Pow(dt, 2) + dt;
            A[1, 1] = 1;
            A[2, 2] = 1;
            A[2, 3] = .5 * Math.Pow(dt, 2) + dt;
            A[3, 3] = 1;
            A[4, 4] = 1;
            A[0, 1] = dt;
            A[5, 5] = 1;

            //These values were measured and collected using Excel (Variance of each element)
            R[0, 0] = 1.4 * Math.Pow(10,-7);
            R[1, 1] = 16.44;
            R[2, 2] = 1.21 * Math.Pow(10, -7);
            R[3, 3] = 16.6;
            R[4, 4] = 54.03;
            R[5, 5] = 4.865;

            //Define H matrix
            H[0,0] = 1;
            H[1,1] = 1;
            H[2,2] = 1;
            H[3,3] = 1;
            H[4,4] = 1;
            H[5,5] = 1;

            //This means nothing but P needs a value
            P = R;
        }

        private double[,] Multiply(double[,] mat1, double[,] mat2)
        {
            double[,] k = new double[mat1.GetLength(0),mat2.GetLength(1)];

            for(int row = 0; row < mat1.GetLength(0); row++)
            {
                for (int col = 0; col < mat2.GetLength(0); col++)
                {
                    for (int inner = 0; inner < mat1.GetLength(1); inner++)
                    {
                        k[row, col] += mat1[row, inner] * mat2[inner, col];
                    }
                }
            }

            return k;
        }

        private double[] Multiply(double[,] mat1, double[] mat2)
        {
            double[] k = new double[mat2.GetLength(0)];

            if (mat1.GetLength(1) == mat2.GetLength(0))
            {
                for (int row = 0; row < mat2.GetLength(0); row++)
                {
                    for (int col = 0; col < mat1.GetLength(1); col++)
                    {
                        k[row] += mat1[row, col] * mat2[col];
                    }
                }
            }

            return k;
        }

        private double[] Subtract(double[] mat1, double[] mat2)
        {
            double[] temp = new double[mat1.Count<double>()];

            for (int row = 0; row < mat1.GetLength(0); row++)
            {
                    temp[row] = mat1[row] - mat2[row];
            }

            return temp;
        }

        private double[,] Subtract(double[,] mat1, double[,] mat2)
        {
            double[,] temp = new double[mat1.GetLength(0), mat2.GetLength(1)];

            for (int row = 0; row < mat1.GetLength(0); row++)
            {
                for (int col = 0; col < mat1.GetLength(0); col++)
                {
                    temp[row, col] = mat1[row, col] - mat2[row, col];
                }
            }

            return temp;
        }

        private double[,] Add(double[,] mat1, double[,] mat2)
        {
            double[,] temp = new double[mat1.GetLength(0),mat2.GetLength(1)];

            for (int row = 0; row < mat1.GetLength(0); row++ )
            {
                for (int col = 0; col < mat1.GetLength(0); col++ )
                {
                    temp[row, col] = mat1[row, col] + mat2[row, col];
                }
            }

            return temp;
        }

        private double[] Add(double[] mat1, double[] mat2)
        {
            double[] temp = new double[mat1.Count<double>()];

            for (int row = 0; row < mat1.GetLength(0); row++)
            {
                    temp[row] = mat1[row] + mat2[row];
            }

            return temp;
        }

        private double[,] Transpose(double[,] mat1)
        {
            double[,] k = new double[mat1.GetLength(0), mat1.GetLength(1)];

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    k[j,i] += mat1[i, j];
                }
            }

            return k;
        }

        private double[,] Divide(double[,] mat1, double[,] mat2)
        {
            double[,] temp = new double[mat1.GetLength(0), mat2.GetLength(1)];

            for (int row = 0; row < mat1.GetLength(0); row++)
            {
                for (int col = 0; col < mat1.GetLength(0); col++)
                {
                    temp[row, col] = mat1[row, col] / mat2[row, col];
                }
            }

            return temp;
        }

        public void Update(Magnometer m, Gyroscope gyro, Accelerometer a, GPS g)
        {
            Measurement[0] = g.Lat;
            Measurement[1] = a.X;
            Measurement[2] = g.Long;
            Measurement[3] = a.Y;
            Measurement[4] = m.Heading;
            Measurement[5] = gyro.Z;

            //should run on first itteration
            if (state == null)
                state = Measurement;

    //Predict new states
            stateP = Multiply(A, state);

    //Predict Process Covariance MAtrix
            //P_future = A*P*A^t (^t is transpose);
            P_future = Multiply(Multiply(A,P),Transpose(A));

    //Update new measurements
            //K = (P_future*H^t)/(H*P_future*H^t + R); //element wise division
            //since H is the idenity matrix, to save time no multiplication needs to be done
            K = Divide(P_future, (Add(P_future,R)));

            state = Add(stateP, Multiply(K, Subtract(Measurement, stateP)));

    //Output
            P = Multiply(Subtract(H,K), P_future);
            //state;

    //write data to file
            //var csv = new StringBuilder();

            //var first = Measurement[0];
            //var second = Measurement[1];
            //var third = Measurement[2];
            //var fourth = Measurement[3];
            //var fifth = Measurement[4];
            //var sixth = Measurement[5];
            //var newLine = string.Format("{0},{1},{2},{3},{4},{5}{6}", first, second, third, fourth, fifth, sixth, Environment.NewLine);

            //csv.Append(newLine);

            //compare output to Data.csv
            //System.IO.File.AppendAllText("Data1.csv", csv.ToString());

        }
    }
}
