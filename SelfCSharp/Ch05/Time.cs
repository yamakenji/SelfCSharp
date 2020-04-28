using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SelfCSharp.Ch05
{
    class Time
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);

            //Console.WriteLine(new DateTime(2020, 03, 27, 17, 43, 26));

            var dt1 = "2020/3/27 17:05:23";
            Console.WriteLine(DateTime.Parse(dt1));

            var dt2 = "令和2年3月27日 17時05分23秒";
            Console.WriteLine(DateTime.Parse(dt2));

            var dt3 = "Donnerstag, 15. Februar 2018 13:17:23";
            Console.WriteLine(DateTime.Parse(dt3, new CultureInfo("de-DE")));

            DateTime dt4;
            if (DateTime.TryParse("2020/3/27 17:10:50", out dt4))
            {
                Console.WriteLine(dt4);
            }

            var str = "20200327171050";
            DateTime dt5 = DateTime.ParseExact(str, "yyyyMMddHHmmss", new CultureInfo("ja-JP"));
            Console.WriteLine(dt5);
        }
    }
}
