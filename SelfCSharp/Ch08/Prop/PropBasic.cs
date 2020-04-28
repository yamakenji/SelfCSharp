using System;

namespace SelfCSharp.Ch08.Prop
{
    class Triangle
    {
        private double _width;
        private double _height;

        // widthプロパティ
        public double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("整数で指定してください。");
                }
                this._width = value;
            }

            get { return this._width; }
        }

        // heightプロパティ
        public double Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("整数で指定してください。");
                }
                this._height = value;
            }

            get { return this._height; }
        }

        public double GetArea()
        {
            return Width * Height / 2;
        }
    }

    class PropBasic
    {
        static void Main(string[] args)
        {
            var t = new Triangle();
            t.Width = 10;
            t.Height = 5;
            System.Console.WriteLine($"三角形の面積は{t.GetArea()}です。");
            t.Width = -5;
        }
    }
}