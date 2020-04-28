using System;
using SelfCSharp.Ch08.Prop;

namespace SelfCSharp.Ch08
{
    class BusinessPerson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は働きます。";
        }

        public new string Show()
        {
            return $"会社員の{this.LastName} {this.FirstName}です。";
        }
    }
    class InheritBasic
    {
        static void Main(string[] args)
        {
            var bp = new BusinessPerson
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }
    }
}