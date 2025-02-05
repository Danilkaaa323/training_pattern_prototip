using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training_pattern_prototip
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public Shape(int x, int y, string color)
        {
            X = x;
            Y = y;
            Color = color;
        }
        protected Shape(Shape source)
        {
            if (source != null)
            {
                X = source.X;
                Y = source.Y;
                Color = source.Color;
            }
        }
        public abstract Shape Clone();
    }
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
        {
            Width = width;
            Height = height;
        }
        protected Rectangle(Rectangle source) : base(source)
        {
            Width = source.Width;
            Height = source.Height;
        }
        public override Shape Clone() => new Rectangle(this);
    }
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Circle(int x, int y, string color, int radius) : base(x, y, color)
        {
            Radius = radius;
        }
        protected Circle(Circle source) : base(source)
        {
            Radius = source.Radius;
        }
        public override Shape Clone() => new Circle(this);
    }
    public class Cube : Shape
    {
        public int Side { get; set; }
        public Cube(int x, int y, string color, int side) : base(x, y, color)
        {
            Side = side;
        }
        protected Cube(Cube source) : base(source)
        {
            Side = source.Side;
        }
        public override Shape Clone() => new Cube(this);
    }
    public class Sphere : Shape
    {
        public int Radius { get; set; }
        public Sphere(int x, int y, string color, int radius) : base(x, y, color)
        {
            Radius = radius;
        }
        protected Sphere(Sphere source) : base(source)
        {
            Radius = source.Radius;
        }
        public override Shape Clone() => new Sphere(this);
    }
    public class Application
    {
        public static void Main(string[] args)
        {
        }
    }
}