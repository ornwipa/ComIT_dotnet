using System;
using System.Collections.Generic;
using Transportation;

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

            Car junker = new Car();
            junker.Seats = 4;
            Console.WriteLine(junker.Seats);
        }
    }
}