using System;
using SelfCSharp.Ch08.ExtensionBasic;

namespace SelfCSharp.Ch08.ExtensionUse
{
    public class ExtensionClient
    {
        static void Main(string[] args)
        {
            var data = "ありがとう！";
            Console.WriteLine(data.Repeat(3));
        }
    }
}