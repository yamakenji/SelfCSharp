using System;

namespace SelfCSharp.Ch08.Construct
{
    class MyParent
    {
        public MyParent(string childName)
        {
            Console.WriteLine($"{childName}の親です。");
        }
    }

    class MyChild : MyParent
    {
        public MyChild(string childName) : base(childName)
        {
            Console.WriteLine($"子の{childName}です。");
        }
    }
    
    public class ConstArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild("まこ");
        }    
    }
}