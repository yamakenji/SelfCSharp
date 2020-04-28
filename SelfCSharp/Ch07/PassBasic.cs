using System;

namespace SelfCSharp.Ch07
{
    class PassBasic
    {
        public int CountUp(int data)
        {
            data++;
            return data;
        }

        static void Main(string[] args)
        {
            var data = 1;
            var p = new PassBasic();
            System.Console.WriteLine(p.CountUp(data));
            System.Console.WriteLine(data);
        }
    }
}