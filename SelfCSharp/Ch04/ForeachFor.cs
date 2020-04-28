using System;

namespace SelfCSharp.Ch04
{
  class ForeachFor
  {
    static void Main(string[] args)
    {
        var data = new[] {"うめ", "さくら","もも"};
        Console.WriteLine("for文での処理");
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine(data[i]);
        }

        Console.WriteLine("foreach文での処理");
        foreach (var val in data)
        {
            Console.WriteLine(val);
        }
    }
  }
}