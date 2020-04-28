using System;

namespace SelfCSharp.Ch07.MethodArgs
{
    class ArgsParams
    {
        public int TotalProducts(params int[] values)
        {
            int result = 1;
            foreach(var value in values)
            {
                result *= value;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var v = new ArgsParams();
            System.Console.WriteLine(v.TotalProducts(12, 15, -1));
            System.Console.WriteLine(v.TotalProducts(5, 7,8, 2));
        }
    }
}