using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class Shortcut
    {
        static void Main(string[] args)
        {
            // string str = "http://abc.com";
            string str = null;

            if (str != null && str.StartsWith("http://")) 
            {
                Console.WriteLine("「http://～」で始まります。");
            }
        }
    }
}
