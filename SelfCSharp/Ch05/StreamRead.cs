using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SelfCSharp.Ch05
{
    class StreamRead
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\yamak\tmp\sample.txt"))
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
    }
}
