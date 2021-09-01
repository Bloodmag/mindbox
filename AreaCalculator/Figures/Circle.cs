using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationLibrary.Figures
{
    public class Circle : Figure
    {
        /// <summary>
        /// Creates a new circle with a radius of <paramref name="radius"/>.
        /// </summary>
        /// <param name="radius">A radius of the circle.</param>
        public Circle(double radius)
        {
            if (radius <= 0 )
                throw new Exception("Circle's radius must be positive");
            Radius = radius;
        }
        /// <summary>
        /// A radius of the circle.
        /// </summary>
        public double Radius { get; set; }
        public double Diameter { get => Radius * 2; set => Radius = value / 2; }

        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double GetPerimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
}
