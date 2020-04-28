using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class CompareString
    {
        static void Main(string[] args)
        {
            string data = "123";
            int data2 = 123;

            Console.WriteLine(data.Equals(data2));
        }
    }
}
