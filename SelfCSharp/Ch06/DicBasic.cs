using System;
using System.Collections.Generic;

namespace SelfCSharp.Ch06
{
    class DicBasic
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                ["Rose"] = "バラ",
                ["SunFlower"] = "ひまわり",
                ["Morning Glory"] = "あさがお"
            };

            System.Console.WriteLine(dic.Count);
            System.Console.WriteLine(dic.ContainsKey("Rose"));
            System.Console.WriteLine(dic.ContainsValue("バラ"));

            dic.TryGetValue("Rose", out string name);
            System.Console.WriteLine(name);

            dic.Add("Tulip", "チューリップ");
            dic["SunFlower"] = "向日葵";

            foreach (var key in dic.Keys)
            {
                System.Console.WriteLine($"{key} : {dic[key]}");
            }

            foreach (var d in dic.Values)
            {
                System.Console.WriteLine(d);
            }

            dic.Remove("Rose");

            foreach (var m in dic)
            {
                System.Console.WriteLine($"{m.Key} : {m.Value}");
            }
        }
    }
}