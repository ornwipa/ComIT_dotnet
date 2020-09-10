using System;
using System.Collections.Generic;

namespace polymorphism
{
    class Person
    {
        public string firstName;
        public string lastName;
        public void printAttribute_hd()
        {
            Console.WriteLine(string.Format("Name: {0}, {1}", this.lastName, this.firstName));
        }
        public virtual void printAttribute_rd()
        {
            Console.WriteLine(string.Format("Name: {0}, {1}", this.lastName, this.firstName));
        }
    }
    class Student : Person
    {
        public string StudentNumber { get; set; }
        public new void printAttribute_hd()
        {
            Console.WriteLine(string.Format("Name: {0}, {1}", this.lastName, this.firstName));
            Console.WriteLine(string.Format("Student Number: {0}", this.StudentNumber));
        }
        public override void printAttribute_rd()
        {
            Console.WriteLine(string.Format("Name: {0}, {1}", this.lastName, this.firstName));
            Console.WriteLine(string.Format("Student Number: {0}", this.StudentNumber));
        }
        public void DrinkCoffee()
        {
            Console.WriteLine("is drinking coffee.");
        }
    }
    class Employee : Person
    {
    }
}    