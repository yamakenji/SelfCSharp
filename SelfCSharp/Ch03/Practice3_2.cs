using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class Practice3_2
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = x;
            x -= 3;

            var builder1 = new StringBuilder("abc");
            var builder2 = builder1;
            builder1.Append("def");

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"builder1 = {builder1}");
            Console.WriteLine($"builder2 = {builder2}");
        }
    }
}
