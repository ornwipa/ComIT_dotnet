using System;

namespace oop_inclass_demo
{   
    internal class Program // without access modifier, internal is default
    {       
        static void Main(string[] args) // static method doesn't need object to execute
        {
            Test testInstance = new Test();
            testInstance.CallPrivateMethod(); // cannnot call private printHello() 

            Bike<int> exampleBike = new Bike<int>(); // need to provide the type in <T>
            // exampleBike.currentGear = 500; // invalid gear
            exampleBike.SetCurrentGear(500); // program doesn't care, data is safe
            Console.WriteLine(exampleBike.GetCurrentGear());

            MyList<bool> list = new MyList<bool>(1); // has to provide size
            list.Add(true);
            Console.WriteLine("First item is {0}", list.GetAt(0));
        }
    }
}