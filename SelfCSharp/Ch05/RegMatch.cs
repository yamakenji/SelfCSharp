using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SelfCSharp.Ch05
{
    class RegMatch
    {
        static void Main(string[] args)
        {
            var str = "電話番号は、084-000-0000です。";
            var rgx = new Regex(@"(\d{2,4})-(\d{2,4})-(\d{4})");
            var match = rgx.Match(str);

            // マッチした場合のみ出力
            if (match.Success)
            {
                Console.WriteLine($"位置:{match.Index} マッチ文字列:{match.Value}");

                foreach(Group m in match.Groups)
                {
                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}
