using System;

namespace Animals
{
    public abstract class Animal
    {
        public bool alive; // attribute that are common and can be inherited
        public void StartLife()
        {
            Console.WriteLine("Hello world!");
        }
        public void MethodStatus()
        {
            Console.WriteLine("Method called from Animal class");
        }
        // public virtual void Sound()
        // {
        //     Console.WriteLine("Animal noise");
        // }
        public abstract void Sound(); // there is no default implementation
    }
    public abstract class Cat : Animal
    {
        public new void MethodStatus() // hiding
        {
            // cannot use base keyword, like base.MethodStatus()
            Console.WriteLine("Method called from Cat class");
        }
        public sealed override void Sound() // redefition
        {
            // base.Sound(); // have access to base implementation
            Console.WriteLine("Miau");
        }
        public abstract void Pounce();
        public static void UseLitter()
        {
        }
    }
    public class Tiger : Cat
    {
        /* cannot override inheried member because it is sealed
        public override void Sound()
        {
        }*/
        public override void Pounce()
        {
            Console.WriteLine("Raaawwrrr");
        }
        public new void UseLitter()
        {
            // cannot re-define static method, can only hide it
        }
    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Woof");
        }
    }
}