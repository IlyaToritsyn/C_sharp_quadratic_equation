using System;

namespace ClassLibrary
{
    /// <summary>
    /// Квадратное уравнение.
    /// </summary>
    public class QuadraticEquation
    {
        /// <summary>
        /// 1 корень уравнения
        /// </summary>
        public double X1 { get; private set; }

        /// <summary>
        /// 2 корень уравнения
        /// </summary>
        public double X2 { get; private set; }

        /// <summary>
        /// Коэффициент a
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Коэффициент b
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Коэффициент c
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Проверка: x - любое число
        /// </summary>
        public bool IsXAnyNumber { get; private set; } = false;

        /// <summary>
        /// Проверка: неверное равенство
        /// </summary>
        public bool IsEquationWrong { get; private set; } = false;

        /// <summary>
        /// Проверка: корень уравнения лишь 1
        /// </summary>
        public bool IsXOne { get; private set; } = false;

        /// <summary>
        /// Проверка: корней нет
        /// </summary>
        public bool NoX { get; private set; } = false;

        public QuadraticEquation(string a, string b, string c)
        {
            NotParsedException notParsed = new NotParsedException(double.TryParse(a, out double numberA), double.TryParse(b, out double numberB), double.TryParse(c, out double numberC));

            if (!notParsed.IsAParsed || !notParsed.IsBParsed || !notParsed.IsCParsed)
            {
                throw notParsed;
            }

            A = numberA;
            B = numberB;
            C = numberC;

            Solve();
        }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            Solve();
        }

        /// <summary>
        /// Решение уравнения.
        /// </summary>
        private void Solve()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        X1 = double.PositiveInfinity;
                        X2 = double.NegativeInfinity;
                        IsXAnyNumber = true;
                    }

                    else
                    {
                        X1 = double.NaN;
                        X2 = double.NaN;
                        IsEquationWrong = true;
                    }
                }

                else
                {
                    X1 = Math.Round(-C / B, 3);
                    X2 = double.NaN;
                    IsXOne = true;
                }
            }

            else
            {
                double D = (B * B) - (4 * A * C);

                if (D == 0)
                {
                    X1 = Math.Round(-B / (2 * A), 3);
                    X2 = Math.Round(-B / (2 * A), 3);
                }

                else if (D > 0)
                {
                    X1 = Math.Round((-B + Math.Sqrt(D)) / (2 * A), 3);
                    X2 = Math.Round((-B - Math.Sqrt(D)) / (2 * A), 3);
                }

                else
                {
                    X1 = double.NaN;
                    X2 = double.NaN;
                    NoX = true;
                }
            }
        }
    }
}
