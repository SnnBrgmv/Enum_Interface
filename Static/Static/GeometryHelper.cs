using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public static class GeometryHelper
    {
        //public const double pi = Math.PI;
        public static double TriangleArea(double a, double b, double c)
        {
            if ((a > 0) && (b > 0) && (c > 0))
            {
                double p = (a + b + c) / 2;
                double A = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return A;
            }

            return 0;
        }
        public static double RectangleArea(double l, double w)
        {
            if ((l > 0) && (w > 0))
            {
                double A = l * w;
                return A;
            }
            return 0;
        }
        public static double CircleArea(double r)
        {
            const double pi = Math.PI;
            if ((r > 0))
            {
                double A = pi * r * r;
                return A;
            }
            return 0;
        }
    }
}
