using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch04
{
    class SwitchWhen
    {
        static void Main(string[] args)
        {
            object obj = "オレオオレオオレオオレオ";
            switch (obj)
            {
                case int i when i >= 15:
                    Console.WriteLine("15以上の数値です。");
                    break;
                case int i:
                    Console.WriteLine("数値です。");
                    break;
                case string str when str.Length < 10:
                    Console.WriteLine("10文字未満の文字列です。");
                    break;
                default:
                    Console.WriteLine("意図しない値です。");
                    break;
            }
        }
    }
}
