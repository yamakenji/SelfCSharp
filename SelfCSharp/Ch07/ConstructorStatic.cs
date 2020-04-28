using System;

namespace SelfCSharp.Ch07
{
    class Message
    {
        int number;

        static Message()
        {
            System.Console.WriteLine("静的コンストラクタ");
        }

        public Message(int number)
        {
            this.number = number;
            System.Console.WriteLine($"通常のコンストラクタ{number}");
        }
    }
    class ConstructorStatic
    {
        static void Main(string[] args)
        {
            var m1 = new Message(1);
            var m2 = new Message(2);
        }
    }
}