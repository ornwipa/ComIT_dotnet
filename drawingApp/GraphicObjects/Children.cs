using System;

namespace drawingApp
{
    public class Rectangle : GraphicObject
    {
        public Rectangle(Point origin) : base(origin)
        {
        }
        public override void draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
        public override void resize()
        {
        }
    }
    public class Circle : GraphicObject
    {
        public Circle(Point origin) : base(origin)
        {
        }
        public override void draw()
        {
            Console.WriteLine("Draw a circle");
        }
        public override void resize()
        {
        }
    }
}