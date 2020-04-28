using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class Increment
    {
        static void Main(string[] args)
        {
            var m = 3;
            var n = ++m;

            Console.WriteLine(m);
            Console.WriteLine(n);

            var m2 = 3;
            var n2 = m2++;

            Console.WriteLine(m2);
            Console.WriteLine(n2);
        }
    }
}
