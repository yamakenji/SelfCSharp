using System;

namespace SelfCSharp.Ch08.Prop
{
    class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string Show()
        {
            return $"名前は{this.LastName}{this.FirstName}です。";
        }
    }

    class PropAuto
    {
        static void Main(string[] args)
        {
            var p = new Person {
                FirstName = "太郎",
                LastName = "山田"
            };

            System.Console.WriteLine(p.Show());
        }
    }
}