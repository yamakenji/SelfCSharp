using System;

namespace SelfCSharp.Ch04
{
    class BreakNest
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    var result = i * j;
                    if (result > 40)
                    {
                      break;
                    }
                    Console.Write($"{result, 2} ");
                }
                Console.WriteLine();
            }
        }
    }
}