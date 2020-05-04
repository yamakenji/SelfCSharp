using System;
using System.Collections.Generic;
using static System.Math;
using System.IO;

class MyClass
{
    public static void Process()
    {
        Console.WriteLine("グローバル名前空間のProcess");
    }
}

namespace SelfCSharp.Ch09.Practice
{
    public class Practice2
    {
        static void PrintList<T>(List<T> list)
        {
            Console.WriteLine(String.Join(",", list.ToArray()));
        }
        
        
        static void Main(string[] args)
        {
            global::MyClass.Process();
            
            var list = new List<int> {10, 15, 30, 60};
            Practice2.PrintList(list);

            try
            {
                var f = new StreamReader(@"data.txt");
            }
            catch (Exception ex) when(
                ex is IOException ||
                ex is ArgumentException)
            {
                // Console.WriteLine(ex.StackTrace);
                Console.WriteLine("ファイルが無いか、指定されていません。");
            }

            var i = -10;
            Console.WriteLine(i >= 0 ? Math.Sqrt(i) : throw new Exception("iは整数でなければなりません!"));
        }
    }
}