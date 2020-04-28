﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch07
{
    class PassOut
    {
        public void GetMaxMin(int x, int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }

        static void Main(string[] args)
        {
            var a = new PassOut();
            int resultMax, resultMin;
            a.GetMaxMin(5, 3, out resultMax, out resultMin);
            Console.WriteLine(resultMax);
            Console.WriteLine(resultMin);
        }
    }
}
