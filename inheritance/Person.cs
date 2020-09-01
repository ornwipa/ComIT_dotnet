using System;
using System.Collections.Generic;

namespace inheritance
{
    public class Person
    {
	    private string firstName;
        private string lastName;
        public List<Person> friends;
        public Person()
        {
            this.friends = new List<Person>();
        }
        // calling base constructor Person() as this()
        public Person(string firstName, string lastName) : this()
	    {
		    this.firstName = firstName;
		    this.lastName = lastName;
            // this.friends is inherited from Person() constructor method
	    }
    }
    public class Employee : Person // child : parent
    {
	    private string companyName;
        // calling parent class Person(arg1, arg2) as base(arg1, arg2)
        public Employee(string companyName, string firstName, string lastName) : base(firstName, lastName)
	    {
		    this.companyName = companyName;
            // this.firstname and this.lastname are inherited from Person(firstName, lastName) 
	    }
    }
}