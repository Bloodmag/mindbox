using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationLibrary.Figures
{

    public class Triangle : Figure
    {
        /// <summary>
        /// Creates a new triangle specified size lengths.
        /// </summary>
        /// <param name="a">Length of the side a.</param>
        /// <param name="b">Length of the side b.</param>
        /// <param name="c">Length of the side c.</param>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Triangle's sides must be positive");
            if (!(a + b >= c || b + c >= a || a + c >= b))
                throw new Exception("One of the triangle's sides must be less or equal than the other's sum.");
            A = a;
            B = b;
            C = c;
        }
        /// <summary>
        /// Length of the side a of the triangle.
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Length of the side b of the triangle.
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Length of the side c of the triangle.
        /// </summary>
        public double C { get; set; }
        /// <summary>
        /// An angle opposite to side a (in radians).
        /// </summary>
        public double Alpha { get => Math.Acos((B * B + C * C - A * A) / (2 * B * C)); }
        /// <summary>
        /// An angle opposite to side b (in radians).
        /// </summary>
        public double Beta { get => Math.Acos((A * A + C * C - B * B) / (2 * A * C)); }
        /// <summary>
        /// An angle opposite to side c (in radians).
        /// </summary>
        public double Gamma { get => Math.Acos((A * A + B * B - C * C) / (2 * A * B)); }

        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }


        public bool IsEquilateral
        {
            get
            {
                return Math.Abs(A - B) < Consts.epsilonDouble && Math.Abs(A - C) < Consts.epsilonDouble;
            }
        }

        /// <summary>
        /// True if the triangle is orthogonal (right).
        /// </summary>
        public bool IsOrthogonal
        //для простоты поддержки (и читаемости) кода можно положиться на получение углов и проверку, равны ли они 90 градусам,
        //но такая реализация будет работать медленнее, каждый угол в отдельности отрабатывает дольше данной реализации
        {
            get
            {
                if (A > B)
                {
                    if (A > C)
                    {
                        //A>B,C
                        return Math.Abs(A * A - (B * B + C * C)) < Consts.epsilonDouble;
                    }
                    else
                    {
                        //C>=A>B
                        return Math.Abs(C * C - (A * A + B * B)) < Consts.epsilonDouble;
                    }
                }
                // A <= B
                else
                {
                    if (B > C)
                    {
                        //B>=A,C
                        return Math.Abs(B * B - (A * A + C * C)) < Consts.epsilonDouble;
                    }
                    else
                    {
                        // C >= B >= A
                        return Math.Abs(C * C - (B * B + A * A)) < Consts.epsilonDouble;
                    }
                }
            }
        }
    }

}
