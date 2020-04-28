using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + 2);
            Console.WriteLine("a" + 5);
            Console.WriteLine(5 + "b");
            Console.WriteLine("1" + "2");
            Console.WriteLine("a" + DateTime.Now);
        }
    }
}
