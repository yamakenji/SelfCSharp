using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch04
{
    class SwitchType
    {
        static void Main(string[] args)
        {
            object obj = "オッペケペー";
            switch(obj)
            {
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;

                case string str:
                    Console.WriteLine(str[0]);
                    break;

                default:
                    Console.WriteLine("意図しない型です。");
                    break;

            }
        }
    }
}
