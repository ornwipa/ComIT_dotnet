namespace measurable_objects
{
    public interface Measureble
    {
        public double calculateArea();
        public static bool sameArea(Measureble m1, Measureble m2)
        {
            return m1.calculateArea() == m2.calculateArea();
        }
    }
    public class Rectangle : Measureble
    {
        private double height;
        private double width;
        public double calculateArea()
        {
            return this.height * this.width;
        }
    }
    public class Circle : Measureble
    {
        private double radius;
        public double calculateArea()
        {
            return this.radius * this.radius * 3.14;
        }
    }
}