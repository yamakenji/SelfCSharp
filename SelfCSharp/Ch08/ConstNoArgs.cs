using System;

namespace SelfCSharp.Ch08
{
    class MyParent
    {
        public MyParent()
        {
            Console.WriteLine("親です。");
        }
    }

    class MyChild : MyParent
    {
        public MyChild()
        {
            Console.WriteLine("子です。");
        }
    }
    
    public class ConstNoArgs
    {
        static void Main(string[] args)
        {
            var c = new MyChild();
        }    
    }
}