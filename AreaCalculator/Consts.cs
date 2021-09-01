using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculationLibrary
{
    class Consts
    {
        //константа для костыльного обхода проблем чисел с плавающей точкой, когда 
        // .1 + .2 = 0.30000000000000004
        public const double epsilonDouble = .000000000000001;
    }
}
