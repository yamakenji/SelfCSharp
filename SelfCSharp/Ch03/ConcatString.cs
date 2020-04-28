using System;

namespace SelfCSharp.Ch03
{
    class ConcatString
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            var result = "";
            for (int i = 0; i < 100000; i++)
            {
                result += "いろは";
            }
            var end = DateTime.Now;
            Console.WriteLine(end.Ticks - start.Ticks);
        }
    }
}
