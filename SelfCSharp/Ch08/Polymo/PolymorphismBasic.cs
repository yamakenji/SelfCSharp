﻿using System;

namespace SelfCSharp.Ch08.Polymo
{
    class Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        // 面積を求める
        public virtual double GetArea()
        {
            return 0.0;
        }
    }

    class Triangle : Figure
    {
        public Triangle(double width, double height) : base(width, height) {}

        public override double GetArea()
        {
            return this.Width * this.Height / 2;
        }
    }

    class Square : Figure
    {
        public Square(double width, double height) : base(width, height) {}

        public override double GetArea()
        {
            return this.Width * this.Height;
        }
    }
    
    public class PolymorphismBasic
    {
        static void Main(string[] args)
        {
            Figure t = new Triangle(10, 30);
            Console.WriteLine(t.GetArea());
            Figure s = new Square(10, 30);
            Console.WriteLine(s.GetArea());
        }
    }
}