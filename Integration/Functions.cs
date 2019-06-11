using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Integration
{
    class Functions
    {
        //public static double F(List<double> coefficients)
        //{
        //    if (coefficients.Count < 3)
        //    {
        //        Console.WriteLine("ERROR");
        //        return 1;
        //    }
        //    return Pow(Sin(coefficients[2]), 2) + coefficients[1] * Sin(coefficients[0]);
        //}

        //public static double Za(List<double> coefficients)
        //{
        //    return 0;
        //}

        //public static double Zb(List<double> coefficients)
        //{
        //    return PI;
        //}

        //public static double Ya(List<double> coefficients)
        //{
        //    return 0;
        //}

        //public static double Yb(List<double> coefficients)
        //{
        //    return coefficients[0];
        //}

        //public static double Xa(List<double> coefficients)
        //{
        //    return 0;
        //}

        //public static double Xb(List<double> coefficients)
        //{
        //    return coefficients[0] + coefficients[1];
        //}
        public static double F(List<double> coefficients)
        {
            if (coefficients.Count < 3)
            {
                Console.WriteLine("ERROR");
                return 1;
            }
            return Exp(coefficients[2]) + Exp(coefficients[1]) + Exp(coefficients[0]);
        }

        public static double Za(List<double> coefficients)
        {
            return 0;
        }

        public static double Zb(List<double> coefficients)
        {
            return 1;
        }

        public static double Ya(List<double> coefficients)
        {
            return 0;
        }

        public static double Yb(List<double> coefficients)
        {
            return coefficients[0];
        }

        public static double Xa(List<double> coefficients)
        {
            return 0;
        }

        public static double Xb(List<double> coefficients)
        {
            return coefficients[0] + coefficients[1];
        }

        public static double F6(List<double> coefficients)
        {
            if (coefficients.Count < 6)
            {
                Console.WriteLine("ERROR");
                return 1;
            }
            return Exp(coefficients[2]) + Exp(coefficients[1]) + Exp(coefficients[0])+ Exp(coefficients[3]) + Exp(coefficients[4]) + Exp(coefficients[5]);
        }

        public static double X1a6(List<double> coefficients)
        {
            return 0;
        }

        public static double X1b6(List<double> coefficients)
        {
            return PI;
        }

        public static double X2a6(List<double> coefficients)
        {
            return 0;
        }

        public static double X2b6(List<double> coefficients)
        {
            return PI;
        }

        public static double X3a6(List<double> coefficients)
        {
            return 0;
        }

        public static double X3b6(List<double> coefficients)
        {
            return 0;
        }
        public static double X4a6(List<double> coefficients)
        {
            return 0;
        }

        public static double X4b6(List<double> coefficients)
        {
            return PI;
        }

        public static double X5a6(List<double> coefficients)
        {
            return 0;
        }

        public static double X5b6(List<double> coefficients)
        {
            return PI;
        }

        public static double X6a6(List<double> coefficients)
        {
            return 0;
        }

        public static double X6b6(List<double> coefficients)
        {
            return 0;
        }

    }
}
