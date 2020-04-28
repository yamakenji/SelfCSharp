using System;

namespace SelfCSharp.Ch08.MethodOverride
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string Show()
        {
            return $"名前は{this.LastName} {this.FirstName}です。";
        }
    }

    class BusinessPerson : Person
    {
        public override string Show()
        {
            return $"会社員の{this.LastName}{this.FirstName}です。";
        }

        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }
    }
    
    class OverrideBasic
    {
        static void Main(string[] args)
        {
            var bp = new BusinessPerson
            {
                FirstName = "けんじ",
                LastName = "やまうち"
            };
            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }
    }
}