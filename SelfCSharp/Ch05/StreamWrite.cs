using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SelfCSharp.Ch05
{
    class StreamWrite
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"C:\Users\yamak\tmp\data.log", append: true))
            {
                writer.WriteLine(DateTime.Now.ToString());
            }
        }
    }
}
