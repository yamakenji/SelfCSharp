using System;

namespace SelfCSharp.Ch04
{
  class WhileDo
  {
    static void Main(string[] args)
    {
      var i = 6;
      do
      {
        System.Console.WriteLine($"{i}番目のループです。");
        i++;
      } while (i < 6);        
    }
  }
}