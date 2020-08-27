using System;
using System.Collections.Generic;
using Transportation;
using Space;

namespace oop_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person guy = new Person();
            guy.firstName = "Joel";
            guy.lastName = "Hill";
            Console.WriteLine(guy);

            // Car junker = new Car();
            // junker.Seats = 4;
            // Console.WriteLine(junker.Seats);

            Car junker = new Car(4, 10);
            for (int i = 0; i < 10; i++)
            {
                junker.Accerate();
            }
            Console.WriteLine(junker);

            Point origin = new Point(5.2, -43.8);
            Point end = new Point(48.5, -23.1);
            Segment line = new Segment(origin, end);
            Console.WriteLine(line);
        }
    }
}