using System;

namespace SelfCSharp.Ch04
{
  class Practice4_1_1
  {
    static void Main(string[] args)
    {
        var score = 36;

        switch  (score)
        {
          case int i when i >= 90:
            System.Console.WriteLine("優");
            break;
          case int i when i >= 70:
            System.Console.WriteLine("良");
            break;
          case int i when i >= 50:
            System.Console.WriteLine("可");
            break;
          default:
            System.Console.WriteLine("不可");
            break;
        }
    } 
  }
}