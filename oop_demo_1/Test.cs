using System;

namespace oop_inclass_demo
{
    public class Test
    {
        private void printHello()
        {
            Console.WriteLine("Hello");
        }
        public void CallPrivateMethod() 
        {
            this.printHello(); // private method can be accessed within the same class
        }
    }
}