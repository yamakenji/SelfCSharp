using System;

namespace SelfCSharp.Ch07.Practice
{
    class MyClass
    {
        public static void GetBmi(double weight, double height)
        {
            System.Console.WriteLine($"BMIは{weight / (height * height)}です。");
        }
    }
    class Pbmi
    {
        static void Main(string[] args)
        {
            MyClass.GetBmi(76.0, 1.75);
        }
    }
}