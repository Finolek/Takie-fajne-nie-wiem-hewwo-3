using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class RownanieKwadratowe
    {
        private double a;
        private double b;
        private double c;

        public RownanieKwadratowe(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double ObliczDelte()
        {
            return b * b - 4 * a * c;
        }

        public double[] ObliczRozwiazanie()
        {
            double delta = ObliczDelte();

            if (delta < 0)
            {
                throw new Exception("Delta jest ujemna");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x, x };
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { x1, x2 };
            }
        }
    }
}
