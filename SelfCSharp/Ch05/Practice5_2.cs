using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace SelfCSharp.Ch05
{
    class Practice5_2
    {
        static void Main(string[] args)
        {
            var rgx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[a-z_0-9-./?%&=]*)?", RegexOptions.IgnoreCase);

            using (var reader = new StreamReader(@"C:\Users\yamak\tmp\SelfCSharp\Chap5\sample.dat"))
            {
                while(!reader.EndOfStream)
                {
                    var result = rgx.Matches(reader.ReadLine());
                    foreach (Match m in result)
                    {
                        Console.WriteLine(m.Value);
                    }
                }
            }
        }
    }
}
