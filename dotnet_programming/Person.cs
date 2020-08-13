using System;

namespace dotnet_programming
{
    class Person
    {
        // construction = defining public method
        public Person() // two methods can have the same name but different arguments
        {

        }
        // public ~Person() // destructor
        public Person(string firstName, string lastName="")
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
	    public string firstName;
	    public string lastName;
	    public string GetFullName()
	    {
		    if (this.lastName == ""){
                return this.firstName;
            }
            else {
                return this.firstName + " " + this.lastName;
            }
	    }
        public string TestSwitch(string name)
        {
            string return_value;
            switch(this.GetFullName()){ // this.GetFullName() gives a string parameter
            // switch(name){ // original statement
                case "Joel":
                    return_value = "Hi:)";
                    break;  // to exit switch statement, to not evaluate next cases
                case "Steve":
                    return ":(";
                default:    // when neither case is true
                    return_value = "Howdy";
                    break;
            }
            return return_value;
        }
        public void TestLoop()
        {
            for (int i = 0; i < 3; ++i){
                Console.WriteLine(i); // printing before incrementing
                break; // exit the loop entirely
            }
            int count = 0;
            while (count < 3){
                Console.WriteLine(++count); // increment before printing
                continue; // skip the rest of this loop and re-enter the next looping
                Console.WriteLine(count); // (warning CS0162) unreachable code detected
            }
        }	
    }
}