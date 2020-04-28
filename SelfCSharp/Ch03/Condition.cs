using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch03
{
    class Condition
    {
        static void Main(string[] args)
        {
            var score = 52;
            Console.WriteLine(score >= 70 ? "合格!" : "不合格...");
        }
    }
}
