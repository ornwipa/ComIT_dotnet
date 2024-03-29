﻿using System;
using System.Collections.Generic;
using System.Linq;
// using other_namespace;

namespace hello_world
{
    class Dog
    {
        public string name;
        public override bool Equals(object obj) // a dog equals another dog
        {
            return this.name == (obj as Dog).name; // if names are the same
        }
    }
    class Program
    {
        public static void practiceGeneral()
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
        
            // exercise: generate the first 20 Fibonacci numbers in the sequence
            var fibonacciNumbers = new List<int> {1, 1};
            while (fibonacciNumbers.Count < 20)
            {
                var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous1 + previous2);
                Console.WriteLine(previous1 + previous2);
            }

            var names = new List<string> {"Bill", "Anna", "Yves"};
            //string[] names = {"Bill", "Anna", "Yves"};
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

            // demo comparing strings and numbers
            string first = "Hello World";
            string second = "Hello World";
            Console.WriteLine("{0}", first.Equals(second));
            Console.WriteLine("{0}", 1 == 1.0);
        }

        /*
        Multi-line commenting example - main entry point of the program
        <tag> jiblish </tag>
        */
        static void Main(string[] args)
        {
            Console.WriteLine(PrintHello()); // call PrintHello method

            Console.ReadKey(); // wait for some input to exit

            WriteHello.PrintHelloFromClass();

            Console.ReadKey();

            WriteHello instance = new WriteHello();
            instance.PrintHelloFromInstance();

            Console.ReadKey();         

            Dog first = new Dog();
            first.name = "Jarvis";
            Dog second = new Dog();
            second.name = "Jarvis";
            Console.WriteLine("{0}", first.Equals(second)); // functions were overridden
        
            int number;
            string number_string = "5 ";
            bool success = int.TryParse(number_string, out number);
            Console.WriteLine("The number is: {0}", number); // when it fails, default value = 0

            int number5 = int.Parse(number_string);
            Console.WriteLine("The number is: {0}", number5);

            // var result = number_string.Split(',');
            string[] result = number_string.Split('.');
        }
        static string PrintHello()
        {
            return "Hello in the main program!";
        }
    }
    public class WriteHello
    {
        public static void PrintHelloFromClass()
        {
            Console.WriteLine("Hello from the other class!");
        }
        string message = "Hello from the instance!";
        public void PrintHelloFromInstance()
        {
            Console.WriteLine(this.message);
        }
        const int number = 0; // define constant, cannot change like variable
        byte instruction = (byte)0xff; // bitwise variable
    }
}