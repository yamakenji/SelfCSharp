using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp.Ch06
{
    class ListLinked
    {
        static void PrintList<T>(LinkedList<T> list)
        {
            Console.WriteLine(String.Join(",", list.ToArray()));
        }
        static void Main(string[] args)
        {
            var animals = new[] {"とら", "うさぎ", "たつ"};
            var list = new LinkedList<string>(animals);

            foreach (var v in list)
            {
                System.Console.WriteLine(v);
            }

            System.Console.WriteLine(list.Count);
            System.Console.WriteLine(list.Contains("とら"));

            list.AddFirst("ねずみ");
            list.AddLast("いのしし");
            list.AddBefore(list.Last, "いぬ");
            list.AddAfter(list.First, "うし");
            PrintList(list);

            list.Remove("たつ");
            list.RemoveLast();
            PrintList(list);

            var node = list.First;
            list.Remove(node);
            list.AddLast(node);
            PrintList(list);

        }
    }
}