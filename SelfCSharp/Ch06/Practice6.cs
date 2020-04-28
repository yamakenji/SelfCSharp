using System;
using System.Collections.Generic;

namespace SelfCSharp.Ch06
{
    class Practice6
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["lettuce"] = "レタス",
                ["spinach"] = "ホウレンソウ",
                ["cucumber"] = "キュウリ"
            };
            dic["cucumber"] = "胡瓜";
            dic.Add("cabbage", "キャベツ");
            dic.Remove("spinach");

            foreach (var m in dic)
            {
                System.Console.WriteLine($"{m.Key} : {m.Value}");
            }

            var list = new List<int> {1, 2, 3, 4};
            list[2] = 50;
            list.Insert(1, 5);
            list.Remove(60);

            foreach (var v in list)
            {
                System.Console.WriteLine(v);
            }
        }
    }
}