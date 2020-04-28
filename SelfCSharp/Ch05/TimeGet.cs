using System;
using System.Collections.Generic;
using System.Text;

namespace SelfCSharp.Ch05
{
    class TimeGet
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2020, 03, 29, 15, 03, 30, 123);
            Console.WriteLine($"{dt.Year}年{dt.Month}月{dt.Day}日 {dt.DayOfWeek} {dt.Hour}時{dt.Minute}分{dt.Second}秒{dt.Millisecond}ミリ秒");
            Console.WriteLine($"経過時間: {dt.Ticks} 年初から{dt.DayOfYear}日目");

            Console.WriteLine("\n");
            // 日付/時刻値を整形する
            Console.WriteLine(dt.ToString("f"));
            Console.WriteLine(dt.ToString("yy/MM/dd (ddd) tt hh:mm:ss"));

            Console.WriteLine("\n");
            // 日付を加算/減算する
            Console.WriteLine(dt.AddYears(10));
            Console.WriteLine(dt.AddMonths(-3));
            Console.WriteLine(dt.AddDays(20));
            Console.WriteLine(dt.AddHours(5));
            Console.WriteLine(dt.AddMinutes(-20));
            Console.WriteLine(dt.AddSeconds(45));

            Console.WriteLine("\n");
            var span = new TimeSpan(3, 15, 30, 0);
            Console.WriteLine(dt.Add(span));

            var dt2 = new DateTime(2009, 08, 05, 05, 15, 10);
            var sub = dt.Subtract(dt2);
            Console.WriteLine(sub.ToString("c"));
            Console.WriteLine(sub.ToString(@"d\.h\:m\:s"));

            // Practice 5.3-2
            var dtn = DateTime.Now;
            var spanfromnow = new TimeSpan(15, 0, 0, 0);
            Console.WriteLine(dtn.Add(spanfromnow));

        }
    }
}
