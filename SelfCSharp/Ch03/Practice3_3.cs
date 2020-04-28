using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class Practice3_3
    {
        static void Main(string[] args)
        {
            string str = "abc.zip";
            if (str.EndsWith(".zip"))
            {
                Console.WriteLine("拡張子は.zipです。");
            }
        }
    }
}
