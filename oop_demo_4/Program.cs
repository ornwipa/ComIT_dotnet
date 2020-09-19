using System;
using breakable_objects;
using measurable_objects;

namespace oop_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Breakable brk = new Glass();
            bool isAssignable = typeof(Breakable).IsAssignableFrom(typeof(Glass));
            return; // true: Breakable[interface] is assignable from Glass[class]
        }
    }
}