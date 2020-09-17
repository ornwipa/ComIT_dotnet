namespace Encapsulation
{
    /// <summary>
    /// Demo for encapsulation, when validation is changed, 
    /// then no need to repeat the changes several times in Main(),
    /// which makes the program more fragile.
    /// </summary>
    public class Test
    {
        private int grade; // make the variable private !!!
        public void setGrade(int n)
        {
            if (n >= 0 && n <= 10)
            {
                this.grade = n;
            }
        }
        public int getGrade()
        {
            return this.grade;
        }
    }    
}