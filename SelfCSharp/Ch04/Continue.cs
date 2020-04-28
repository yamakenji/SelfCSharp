using System;

namespace SelfCSharp.Ch04
{
    class Continue
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i <= 100 ; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine($"1～100までの偶数の合計値は{sum}です。");

            int j = 0;
            int jsum = 0;

            while (j <= 100)
            {
                j++;
                if (j % 2!= 0)
                {
                    continue;
                }
                jsum += j;
            }
            Console.WriteLine($"1～100までの偶数の合計値は{jsum}です。");

        }
    }
}