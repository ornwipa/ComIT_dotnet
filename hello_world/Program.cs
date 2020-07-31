using System;
using System.Collections.Generic;
using System.Linq;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxi = int.MaxValue;
            int mini = int.MinValue;
            Console.WriteLine($"The range of integers is {mini} to {maxi}");
            int what = maxi + 1;
            Console.WriteLine($"An example of overflow: {what}");

            double maxdb = double.MaxValue;
            double mindb = double.MinValue;
            Console.WriteLine($"The range of double is {mindb} to {maxdb}");
            double thirdb = 1.0/3.0;
            Console.WriteLine(thirdb);

            decimal maxdc = decimal.MaxValue;
            decimal mindc = decimal.MinValue;
            Console.WriteLine($"The range of decimal is {mindc} to {maxdc}");
            decimal thirdc = 1.0M/3.0M;
            Console.WriteLine(thirdc);

            // decimal type has a smaller range but greater precision than double.

            Console.WriteLine("The current time is " + DateTime.Now);

            int a = 3;
            int b = 5;
            if ((a + b > 10) && (a == b) || (a != b))
            {
                Console.WriteLine("foo");
            }
            else{
                Console.WriteLine("not foo");
            }

            int counter = 0;
            while (counter < 4)
            {
                Console.WriteLine($"The counter is {counter}.");
                counter++;
            }
            counter = 0;
            do
            {
                Console.WriteLine($"The counter is {counter}.");
                counter++;
            } while (counter < 4);

            for (int counterf = 0; counterf < 4; counterf++)
            // for initializer; for condition; for iterator
            {
                Console.WriteLine($"The counter is {counterf}.");
            }

            // exercise: sum of all integers 1 through 20 that are divisible by 3
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}.");

            var names = new List<string> {"Jesselyn", "Joel", "Pablo"};
            //string[] names = {"Jesselyn", "Joel", "Pablo"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            names.Add("Ornwipa");
            Console.WriteLine(names[names.Count-1] + " is added to the list.");
            Console.WriteLine($"The list has {names.Count} people.");

            var foundIndex = names.IndexOf("Ornwipa");
            Console.WriteLine($"The name {names[foundIndex]} is at index {foundIndex}");
            var notFoundIndex = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFoundIndex}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // exercise: generate the first 20 Fibonacci numbers in the sequence
            var fibonacciNumbers = new List<int> {1, 1};
            while (fibonacciNumbers.Count < 20)
            {
                var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous1 + previous2);
                Console.WriteLine(previous1 + previous2);
            }
        }
    }
}