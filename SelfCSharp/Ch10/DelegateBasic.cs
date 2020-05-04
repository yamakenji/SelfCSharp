using System;

namespace SelfCSharp.Ch10
{
    delegate void Process(string str);
    
    public class DelegateBasic
    {
        static void Run(string s)
        {
            Console.WriteLine($"{s}走ります。");
        }

        static void Main(string[] args)
        {
            var p = new Process(Run);
            p("ちょこちょこ");
        }
    }
}