using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch04
{
    class IfNest
    {
        static void Main(string[] args)
        {
            var i = 2;
            var j = 3;
            if (i == 1)
            {
                if (j == 1)
                {
                    Console.WriteLine("変数i,jは1です。");
                }
                else
                {
                    Console.WriteLine("変数iは1ですが、jは1ではありません。");
                }
            }
            else
            {
                Console.WriteLine("変数iは1ではありません。");
            }
        }
    }
}
