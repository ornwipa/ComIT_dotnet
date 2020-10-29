using System;
using System.Collections.Generic;

namespace delegate_example
{
    public delegate void Compare(object a, object b);
    class Program
    {
        public static bool IsALargerThanB(object a, object b)
	    {
		    return true;
	    }
        public static bool IsASmallerThanB(object a, object b)
	    {
		    return false;
	    }
        public static void SortObjects(List<object> objects, Func<object, object, bool> compare)
        {
            
        }
        static void Main(string[] args)
        {
            Func<object, object, bool> compare = IsALargerThanB;
            SortObjects(new List<object>(){"dfsdoinf", "sliewrk"}, compare);
        }
    }
}
