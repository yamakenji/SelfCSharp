using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SelfCSharp.Ch05
{
    class RegMatches
    {
        static void Main(string[] args)
        {
            var str = "自宅の電話番号は、084-000-0000です。携帯は、080-0000-0000です。";
            var rgx = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");
            var result = rgx.Matches(str);
            Console.WriteLine(result.Count);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);

            foreach (Match m in result)
            {
                Console.WriteLine($"位置: {m.Index} 長さ: {m.Length} マッチ文字列: {m.Value}");
            }
        }
    }
}
