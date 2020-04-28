using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class CompareDouble
    {
        static void Main(string[] args)
        {
            const double EPSLON = 0.00001;
            double x = 0.2 * 3;
            double y = 0.6;
            Console.WriteLine(Math.Abs(x - y) < EPSLON);
        }
    }
}
