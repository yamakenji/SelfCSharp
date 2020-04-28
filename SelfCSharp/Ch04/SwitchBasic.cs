using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch04
{
    class SwitchBasic
    {
        static void Main(string[] args)
        {
            var rank = "あ";

            switch (rank)
            {
                case "甲":
                    Console.WriteLine("大変良いです。");
                    break;

                case "乙":
                    Console.WriteLine("良いです");
                    break;

                case "丙":
                    Console.WriteLine("頑張りましょう");
                    break;

                default:
                    Console.WriteLine("???");
                    break;
            }
        }
    }
}
