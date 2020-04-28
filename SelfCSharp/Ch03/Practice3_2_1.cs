using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelfCSharp.Ch03
{
    class Practice3_2_1
    {
        static void Main(string[] args)
        {
            string value = null;
            Console.WriteLine(value != null ? value : "既定値");
            Console.WriteLine(value ?? "既定値");
            Console.WriteLine("123".Equals(123));
            Console.WriteLine(new StringBuilder("X") == new StringBuilder("X"));
            Console.WriteLine((new[] { 1, 2, 3 }).SequenceEqual(new[] { 1, 2, 3 }));
        }
    }
}
