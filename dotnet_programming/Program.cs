using System;

namespace dotnet_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Joel";
            Person joel = new Person("", ""); // keyword 'new' for assigning new variable/object
            // need to create the instance with both arguments, firstName and lastName
            // Person joel = new Person(); // this line is no longer ok as the constructor require parameters
            
            SetPersonName(joel, name);
            Console.WriteLine("Person's name is {0}.", joel.firstName); // vary with the method SetPersonName
            Console.WriteLine("Variable is {0}.", name); // directly use variable declared in the method Main

            // method invocation ... <var identifier>.<method identifier>(<argument>);
            joel.firstName = "Joel"; // standalone <instance>.<attribute> is not valid, but assignment is ok
            joel.GetFullName();

            // TestLoop(); // (error CS0103) does not exist in the current context
            joel.TestLoop(); // cannot use Person.TestLoop(), has to be an instance, not a class
            Console.WriteLine(joel.TestSwitch(""));
        }
        static void SetPersonName(Person person, string name)
        {
            name = "Steve";
            person.firstName = name; // the name declared above is set to the person in the method's argument
        }
    }
}