using System;
using System.Collections.Generic;

namespace drawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // store references to derived object
            GraphicObject graphic;
            graphic = new Rectangle(new Point(1,0));
            // invoke method move, corresponding to the object type being referenced
            graphic.move(0,1);

            // store references to derived object
            GraphicObject[] graphs = new GraphicObject[2];
            graphs[0] = new Rectangle(new Point(0,0));
            graphs[1] = new Circle(new Point(0,0));
            // invoke method move, corresponding to the object type being referenced
            for (int i = 0; i < graphs.Length; i++)
            {
                graphs[i].move(0,0);
            }
        }
    }
}