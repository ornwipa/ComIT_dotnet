using System;

namespace exception
{
    public class InvalidUserInput : Exception
    {
        public InvalidUserInput(string message, Exception innerException) : base(message, innerException)
        {}
    }
    class Program
    {
        /// <summary>
        /// Create full name from last and first name
        /// </summary>
        /// <param name="args">Array containing first ant last name stating at index</param>
        /// <exception cref="InvalidUserInput">Description</exception>
        /// <returns>full name</returns>
        public static string GetNameFromArgs(string[] args)
        {
            string first_name;
            string last_name;
            try {
                first_name = args[0];
                last_name = args[1];
            }
            catch (IndexOutOfRangeException e) // arguments are null, the actual error
            { 
                throw new InvalidUserInput("First and last names must be provided.", e);
            }
            return first_name + " " + last_name;
        }

        static void Main(string[] args) // dotnet run --firstName --lastName
        {
            string full_name;
            try {
                full_name = GetNameFromArgs(args);
            }
            catch (InvalidUserInput e) // defined type of exception, thrown from method
            {
                Console.WriteLine("{0}", e.Message);
                Console.Error.WriteLine(e.ToString());
                return;
            }
            Console.WriteLine("{0}", full_name);
        }
    }
}