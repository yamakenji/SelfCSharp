using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp.Ch06
{
    class ListQueue
    {
        static void Main(string[] args)
        {
            var list = new Queue<int>();

            list.Enqueue(10);
            list.Enqueue(15);
            list.Enqueue(30);
            list.Enqueue(60);

            foreach (var v in list)
            {
                System.Console.WriteLine(v);
            }

            System.Console.WriteLine(list.Count());
            System.Console.WriteLine(list.Contains(30));
            System.Console.WriteLine(list.Dequeue());
            System.Console.WriteLine(list.Peek());
            System.Console.WriteLine(list.Dequeue());

            System.Console.WriteLine(String.Join(",", list.ToArray()));
        }
    }
}