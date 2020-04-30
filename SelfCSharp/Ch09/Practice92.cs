using System;
using System.Threading.Channels;

namespace SelfCSharp.Ch09
{
    enum Weekday
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
        All = 99,
    }
    
    public class Practice92
    {
        static void Main(string[] args)
        {
            var w = Weekday.All;
            Console.WriteLine(w.ToString("D"));
        }
    }
}