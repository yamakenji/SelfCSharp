using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class Substitution
    {
        static void Main(string[] args)
        {
            var x = 1;
            var y = x;
            x += 10;
            Console.WriteLine(x);
            Console.WriteLine(y);

            var builder1 = new StringBuilder("あいう");
            var builder2 = builder1;
            builder1.Append("えお");
            Console.WriteLine(builder1.ToString());
            Console.WriteLine(builder2.ToString());
        }
    }
}
