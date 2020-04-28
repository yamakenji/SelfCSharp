using System;

namespace SelfCSharp.Ch04
{
  class WhileBasic
  {
      static void Main(string[] args)
      {
          var i = 6;

          while (i < 6)
          {
            System.Console.WriteLine($"{i}番目のループです。");
            i++;
          }
      }
  }
}