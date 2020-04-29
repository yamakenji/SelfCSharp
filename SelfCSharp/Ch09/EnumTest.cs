using System;

namespace SelfCSharp.Ch09
{
    class EnumTest
    {
        static void Main(string[] args)
        {
            var s = Season.Spring;
            System.Console.WriteLine(s);
            System.Console.WriteLine(s.ToString());
            System.Console.WriteLine(s.ToString("D"));
            System.Console.WriteLine(s.ToString("X"));
            System.Console.WriteLine("------");

            var str = (Season)Enum.Parse(typeof(Season), "Summer");
            var num = (Season)Enum.Parse(typeof(Season), "1");
            System.Console.WriteLine($"{str} - {str.GetType()}");
            System.Console.WriteLine($"{num} - {num.GetType()}");

            var success = Enum.TryParse("Summer", out Season result);
            System.Console.WriteLine(success ? $"{result}" : "Failure");

        }
    }
}