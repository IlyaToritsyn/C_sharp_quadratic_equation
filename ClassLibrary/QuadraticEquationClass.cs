using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class QuadraticEquation
    {
        public double X1
        {
            get; set;
        }

        public double X2
        {
            get;
            set;
        }

        public QuadraticEquation(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a.ToString();
            B = b.ToString();
            C = c.ToString();
        }

        public string A { get; }
        public string B { get; }
        public string C { get; }

        public bool f1 { get; set; }
        public bool f2 { get; set; }
        public bool f3 { get; set; }
        public bool f4 { get; set; }

        public void Answer()
        {
            MyException myException = new MyException(double.TryParse(A, out double a), double.TryParse(B, out double b), double.TryParse(C, out double c));

            if (!myException.flag1 || !myException.flag2 || !myException.flag3)
            {
                throw myException;
            }

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        X1 = double.PositiveInfinity;
                        X2 = double.NegativeInfinity;
                        f1 = true;
                    }

                    else
                    {
                        X1 = double.NaN;
                        X2 = double.NaN;
                        f2 = true;
                    }
                }

                else
                {
                    X1 = -c / b;
                    X2 = double.NaN;
                    f3 = true;
                }
            }

            else
            {
                double D = b * b - 4 * a * c;
            }
        }
    }
}
