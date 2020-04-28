using System;

namespace SelfCSharp.Ch07.Construct
{
    class Person
    {
        public string firstName;
        public string lastName;

        // コンストラクタ
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person() : this("権兵衛", "名無") {}

        public void Show()
        {
            System.Console.WriteLine($"名前は{this.lastName} {this.firstName}です。");
        }
    }

    class ConstructBasic
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Show();
        }
    }
}