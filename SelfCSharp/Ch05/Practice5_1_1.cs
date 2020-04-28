using System;

namespace SelfCSharp.Ch05
{
    class Practice5_1_1
    {
      static void Main(string[] args)
      {
          var str = "プログラミング言語";
          var str2 = "スズキ,タロウ,男,50歳,広島県";
          System.Console.WriteLine(str.Substring(4, 3));
          var result = str2.Split(',');
          System.Console.WriteLine(string.Join('\t', result));

          foreach(var tmp in result)
          {
            System.Console.WriteLine(tmp);
          }

      }
    }
}