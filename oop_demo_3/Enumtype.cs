namespace Enumtype 
{
    enum Weekday
    {
	    Sun = 4, Mon, Tue = 10, Wed, Thu = 'a', Fri, Sat = '☔'
        // default the first value at 0 if not assigned
        // increment the value from the one that comes before in series
        // if a character is assigned then it is stored as an integer
    }
    class AnotherTest
    {
        public static void useEnum()
        {
            Weekday day;
            day = Weekday.Mon; // assignment
            if (day == Weekday.Fri) // comparison
            {}
            if (day == 0)
            {}
            day = (Weekday)9; // use integer and cast type
        }
    }
} 