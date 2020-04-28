using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp.Ch06
{
    class ListStack
    {
        static void Main(string[] args)
        {
            var s = new Stack<int>();
            s.Push(10);
            s.Push(15);
            s.Push(30);
            s.Push(60);

            foreach (var v in s)
            {
                System.Console.WriteLine(v);
            }

            System.Console.WriteLine(s.Count());
            System.Console.WriteLine(s.Contains(30));
            System.Console.WriteLine(s.Pop());
            System.Console.WriteLine(s.Peek());
            System.Console.WriteLine(s.Pop());

            System.Console.WriteLine(String.Join(",", s.ToArray()));
        }
    }
}