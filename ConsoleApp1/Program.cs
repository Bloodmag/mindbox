using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using AreaCalculationLibrary.Figures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var f = new Triangle(5, 5, 5);
            Console.WriteLine(f.Alpha);
            Console.WriteLine(f.Beta);
            Console.WriteLine(f.Gamma);
            Console.WriteLine(f.IsOrthogonal);
            Console.WriteLine(f.IsEquilateral);

            var c = new Circle(5);
            Console.WriteLine(c.Diameter);
            Console.WriteLine(c.GetArea());
            Console.WriteLine(c.GetPerimeter());
        }

    }



   
}


