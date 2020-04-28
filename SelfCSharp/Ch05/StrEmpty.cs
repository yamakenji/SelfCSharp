using System;
using System.Linq;

namespace SelfCSharp.Ch05
{
    class StrEmpty
    {
        static void Main(string[] args)
        {
            // var str1 = "";
            // var str2 = "    ";
            // //var str3 = "にわにわにわにわとりがいる";
            // var str3 = "1234567890";
            var str4 = "WINGSプロジェクト";
            // var str5 = "WINGS2号";
            var path = @"C:\data\wings.jpg";

            // Console.WriteLine(String.IsNullOrEmpty(str1));
            // Console.WriteLine(String.IsNullOrEmpty(str2));

            // Console.WriteLine(String.IsNullOrWhiteSpace(str1));
            // Console.WriteLine(String.IsNullOrWhiteSpace(str2));

            // Console.WriteLine(str3.IndexOf("34"));
            // Console.WriteLine(str3.IndexOf("にも"));
            // Console.WriteLine(str3.LastIndexOf("34"));
            // Console.WriteLine(str3.IndexOf("34", 3));
            // Console.WriteLine(str3.LastIndexOf("34", 3));
            // Console.WriteLine(str3.IndexOf("34", 2, 5));
            // Console.WriteLine(str3.LastIndexOf("34", 5, 3));
            // Console.WriteLine(str3.IndexOf("にわ", 5, 10));
            // Console.WriteLine(str4.Contains("プロ"));
            // Console.WriteLine(str4.StartsWith("WINGS"));
            // Console.WriteLine(str4.EndsWith("WINGS"));
            // Console.WriteLine(str5.Any(ch => Char.IsDigit(ch)));
            // Console.WriteLine(str5.All(ch => Char.IsDigit(ch)));
            Console.WriteLine(str4.Substring(5, 2));
            Console.WriteLine(path.Substring(path.LastIndexOf(".") + 1));
            Console.WriteLine(path[0]);
            foreach (var s in str4)
            {
              Console.WriteLine(s);
            }
        }
    }
}