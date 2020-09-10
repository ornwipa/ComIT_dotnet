using System;

namespace drawingApp
{
    public abstract class GraphicObject
    {
        public Point origin;
        public GraphicObject(Point origin)
        {
            this.origin = origin;
        }
        public virtual void move(int x, int y)
        {
            this.origin.x = x;
            this.origin.y = y;
            this.draw(); // "this" attribure refers to object whose method is being executed.
        }
        public virtual void draw()
        {
            Console.WriteLine("Draw a graphic object");
        }
        public virtual void resize()
        {
            Console.WriteLine("Resize a graphic object");
        }
    }
}