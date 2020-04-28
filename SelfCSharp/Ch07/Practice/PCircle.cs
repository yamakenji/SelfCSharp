using System;

namespace SelfCSharp.Ch07.Practice
{
    class Circle
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle() : this(1) {}

        public double GetArea()
        {
            return this.radius * this.radius * Math.PI;
        }
    }

    class PCircle
    {
        static void Main(string[] args)
        {
            var c = new Circle();
            System.Console.WriteLine(c.GetArea());
        }
    }


}