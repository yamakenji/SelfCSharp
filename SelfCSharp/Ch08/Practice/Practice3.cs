using System;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Ch08.Practice
{
    class Animal
    {
        private int _age;
        
        public string Name { get; private set; }

        public int Age
        {
            get { return _age; }
            private set
            {
                if (value < 0)
                {
                    value = 0;
                }

                _age = value;
            }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Intro()
        {
            Console.WriteLine($"僕の名前は{this.Name}, {this.Age}だよ。");
        }
    }
    

    public class Practice3
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("モンキ", 12);
            a.Intro();
        }
    }
}