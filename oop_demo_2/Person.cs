using System;
using System.Collections.Generic;

namespace oop_demo
{
    public class Person
    {
        private List<Person> friends;
        public Person()
        {
            this.friends = new List<Person>();
        }
        public Person(List<Person> friends)
        {
            this.friends = friends;
        }
        
        public string firstName;
        public string lastName;
        public override string ToString()
        {
            string baseToString = base.ToString(); // base = reference to the base implementation, showing type
            return baseToString + "\n" + "First name: " + this.firstName + "\n" + "Last name: " + this.lastName;
        }
    }
}