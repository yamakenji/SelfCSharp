using System;

namespace SelfCSharp.Ch08
{
    class EliteBusinessPerson : BusinessPerson
    {
        public new string Work()
        {
            var result = base.Work();
            return $"{result}いつでもテキパキと";
        }
    }
    
    class InheritBaseCall
    {
        static void Main(string[] args)
        {
            var ep = new EliteBusinessPerson
            {
                FirstName = "けんじ",
                LastName = "やまうち"
            };
            Console.WriteLine(ep.Work());
        }    
    }
}