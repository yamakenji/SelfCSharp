using System;

namespace SelfCSharp.Ch07
{
    class PassArray
    {
        public int[] Update(int[] data)
        {
            data[0] = 5;
            return data;
        }

        static void Main(string[] args)
        {
            var data = new[] {2, 4, 6};
            var p = new PassArray();
            System.Console.WriteLine(p.Update(data)[0]);
            System.Console.WriteLine(data[0]);
        }
    }
}