using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch06
{
    class ListForeach
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "バラ",
                "ひまわり",
                "あざみ"
            };

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            var list2 = new List<int>
            {
                15,23,29,37
            };

            foreach (var s2 in list2)
            {
                Console.WriteLine(s2);
            }
        }
    }
}
