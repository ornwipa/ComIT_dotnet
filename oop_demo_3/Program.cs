using Enumtype;

namespace oop_demo
{
    class Thing
    {
        private int num = 0;
        static void Main(string[] args)
        {
            // num = 0 would fail, not in the context of Thing
            // need an instance whose attribute will be assigned
            Thing thing = new Thing();
            thing.num = 0;

            AnotherTest.useEnum(); // just an entry point for debugging
        }
        void assignZero()
        {
            num = 0; // still in the context of Thing
        }
    }       
}