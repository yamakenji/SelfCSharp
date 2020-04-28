using System;

namespace SelfCSharp.Ch07
{
    class ScopeBasic
    {
        public string data = "フィールド";

        public string Show()
        {
            string data = "ローカル";
            return data;
        }
        static void Main(string[] args)
        {
            var s = new ScopeBasic();
            System.Console.WriteLine(s.Show());
            System.Console.WriteLine(s.data);
        }
    }
}