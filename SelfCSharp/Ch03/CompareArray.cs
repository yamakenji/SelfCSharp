using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelfCSharp.Ch03
{
    class CompareArray
    {
        static void Main(string[] args)
        {
            var data1 = new[] { "い", "ろ", "は" };
            var data2 = new[] { "い", "ろ", "は" };

            Console.WriteLine(data1 == data2);
            Console.WriteLine(data1.Equals(data2));
            Console.WriteLine(data1.SequenceEqual(data2));

        }
    }
}
