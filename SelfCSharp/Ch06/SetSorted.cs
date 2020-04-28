using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp.Ch06
{
    class SetSorted
    {
        static void PrintSet<T>(SortedSet<T> set)
        {
            Console.WriteLine(String.Join(",", set.ToArray()));
        }

        static void Main(string[] args)
        {
            var set = new SortedSet<int> {30, 60, 10, 15};
            set.Add(10);
            set.Add(5);
            set.Remove(60);

            foreach (var s in set)
            {
                System.Console.WriteLine(s);
            }

            System.Console.WriteLine(set.Count);
            System.Console.WriteLine(set.Min);
            System.Console.WriteLine(set.Max);
            
            var set2 = new SortedSet<int> {10, 15, 30};
            System.Console.WriteLine(set.IsSupersetOf(set2));

            set.ExceptWith(new HashSet<int> {15, 30});
            set.Remove(10);
            PrintSet(set);
        }
    }
}