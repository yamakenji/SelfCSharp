using System;

namespace SelfCSharp.Ch08.Practice
{
    class MyClass
    {
        protected double value;

        public MyClass(double value)
        {
            this.value = value;
        }

        public virtual string GetValue()
        {
            return this.value.ToString("F1");
        }
    }

    class MySubClass : MyClass
    {
        public MySubClass(double value) :base(value) {}

        public override string GetValue()
        {
            return $"[{base.GetValue()}]";
        }
    }
    public class Practice4
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass(12);
            Console.WriteLine(mc.GetValue());
        }
    }
}