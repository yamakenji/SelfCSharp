using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch04
{
    class IfBasic
    {
        static void Main(string[] args)
        {
            var i = 20;
            if (i == 10)
            {
                Console.WriteLine("変数iは10です。");
            }
            else
            {
                Console.WriteLine("変数iは10ではありません。");
            }
        }
    }
}
