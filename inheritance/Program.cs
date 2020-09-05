using System;
using System.Collections.Generic;
using Animals;

namespace inheritance
{
    public class Program<T>
    {
        public static void Run(List<T> items)
        {
            // Person frontdeskPerson1 = new Person("first", "last");
            // Employee frontdeskPerson2 = new Employee("SunCor", "Steve", "Jobs");
            
            // Animal animal = new Animal(); // cannot create instances of abstract class
            Tiger cat = new Tiger();

            cat.MethodStatus();
            cat.Sound();

            (cat as Animal).MethodStatus(); // casting doesn't work as method still exists but just hidden
            (cat as Animal).Sound(); // casting works as method is overridden

            cat.Pounce();

            foreach (T a in items)
            {
                if (a.GetType() == typeof(Animal))
                {
                    (a as Animal).Sound();
                }
                if (a.GetType() == typeof(Tiger))
                {
                    (a as Tiger).Sound();
                }
            }
            return; // set a breat point here
        }
    }
    public class RealProgram
    {
        public static void Main(string[] arg)
        {
            Tiger cat = new Tiger();

            Dog dog = new Dog();
            dog.alive = true; 

            List<Animal> animals = new List<Animal>() {cat, dog};
            Program<Animal>.Run(animals);
        }
    }
}