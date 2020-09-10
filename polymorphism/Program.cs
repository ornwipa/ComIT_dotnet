using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Person guy = new Person();
            guy.firstName = "Tom";
            guy.lastName = "McDonald";
            guy.printAttribute();
            */

            Student stu = new Student();
            stu.firstName = "Tom";
            stu.lastName = "McDonald";
            stu.StudentNumber = "xxxxx";
            // stu.printAttribute();

            Person per = stu; // implicitly cast a Student object as Person
            per.printAttribute_hd(); // use parent method from Person class
            per.printAttribute_rd(); // use child method from Student class

            /* explicit conversion
            Employee emp = (Employee)per;
            Unhandled exception. System.InvalidCastException: Unable to cast 
            object of type 'polymorphism.Student' to type 'polymorphism.Employee' */

            Student student = (Student)per; // general or known method, new instance
            student.DrinkCoffee();

            (per as Student).DrinkCoffee(); // cast parent class to use child method
        }
    }
}