using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch07
{
    class Practice7_5_1
    {
        public static (double addition, double subtraction) AddSubstract(double x, double y)
        {
            return (x + y, x - y);
        }

        static void Main(string[] args)
        {
            var t = Practice7_5_1.AddSubstract(15, 13);
            Console.WriteLine(t.addition);
            Console.WriteLine(t.subtraction);
        }
    }
}
