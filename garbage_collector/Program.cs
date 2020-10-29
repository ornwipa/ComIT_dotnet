using System;
using System.Threading.Tasks; // run in parallel

namespace garbage_collector
{
    class Garbage
    {
        private bool isRunning = false;
        public void Start() 
        {
            this.isRunning = true;
            this.Work();
        }
        public void Stop() 
        {
            this.isRunning = false;
        }
        private async void Work() // async tells the compiler to run parallel
        {
            await Task.Run(() => { // await is used in front of method
            // use lamda definition, i.e. () => {}, 
            // create a function that is just declared and used at the moment
            // the scope of () => {} is inside the method Work() only
                while (this.isRunning)
                {
                    Console.WriteLine("Working...");
                }
            });
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garbage garbage = new Garbage();

            Console.WriteLine("Starting garbage process");
            garbage.Start();

            Console.WriteLine("Setting garbage reference to NULL");
            garbage = null;

            System.GC.Collect();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); // get input to not end the process
        }
    }
}