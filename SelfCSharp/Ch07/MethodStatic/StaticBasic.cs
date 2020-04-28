using System;

namespace SelfCSharp.Ch07.MethodStatic
{
    class Figure
    {
        public static double Pi = 3.14;
        public static void GetCircleArea(double r)
        {
            System.Console.WriteLine($"円の面積は{r * r * Pi}です。");
        }
        public static void GetTriangleArea(int width, int height)
        {
            System.Console.WriteLine($"三角形の面積は{width * height / 2}です。");
        }
    }

    class StaticBasic
    {
        static void Main(string[] args)
        {
            Figure.GetTriangleArea(10, 20);
            System.Console.WriteLine(Figure.Pi);
            Figure.GetCircleArea(5);
        }
    }
}