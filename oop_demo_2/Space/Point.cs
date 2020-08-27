namespace Space
{
    public class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x:" + this.x + "\n" + "y:" + this.y;
        }
    }
}