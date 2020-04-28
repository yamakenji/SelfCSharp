using System;

namespace SelfCSharp.Ch07
{
    class MethodLocal
    {
        static void Main(string[] args)
        {
            double Discount(int price, double rate)
            {
                return price * (1 - rate);
            }

            System.Console.WriteLine(Discount(1000, 0.2));
        }
    }
}