using System;

namespace SelfCSharp.Ch09
{
    class MyClass
    {
        class MyHelper // internal 同じアセンブリの中からアクセスが可能
        {
            public void Show()
            {
                Console.WriteLine("Nested Class is running!");
            }
        }

        public void Run()
        {
            var helper = new MyHelper();
            helper.Show();
        }
    }
    
    public class NestedBasic
    {
        static void Main(string[] args)
        {
            var c = new MyClass();
            c.Run();
            
            // var h = new MyClass.MyHelper();
        }    
    }
}