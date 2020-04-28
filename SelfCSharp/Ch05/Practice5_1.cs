using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch05
{
    class Practice5_1
    {
        static void Main(string[] args)
        {
            var str = "となりのきゃくはよくかきくうきゃくだ";
            Console.WriteLine(str.LastIndexOf("きゃく"));

            var loc = "弘前";
            var temp = 15.156;
            Console.WriteLine(String.Format("{0}の気温は、{1:F1}℃です。", loc, temp));

            var str2 = "ボクの名前は太郎です。";
            Console.WriteLine(str2.Replace("ボク", "私"));

            var dt1 = DateTime.Now;
            var span = new TimeSpan(5, 4, 0, 0);
            Console.WriteLine(dt1.Add(span));

            var dt2 = new DateTime(2018, 02, 13);
            var dt3 = new DateTime(2020, 08, 04);
            var sub = dt3.Subtract(dt2);
            Console.WriteLine(sub.ToString("c"));
        }
    }
}
