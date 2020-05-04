using System;
using System.Runtime.CompilerServices;

namespace SelfCSharp.Ch09.Practice
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public Point() : this(1, 1) {}

        public void Show()
        {
            Console.WriteLine($"({this.X},{this.Y})");
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point
                (p1.X + p2.X,
                p1.Y + p2.Y);
        }

        public static explicit operator double(Point p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }
    }

    class Practice4
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            p1.Show();
            var p2 = new Point(3 ,4);
            var p12 = p1 + p2;
            Console.WriteLine($"{p12.X},{p12.Y}");
            
            var p3 = new Point(10 , 20);
            Console.WriteLine((double)p3);
        }
    }
}