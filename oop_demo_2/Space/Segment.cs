namespace Space
{
    public class Segment
    {
        private Point origin;
        private Point end;
        public Segment(Point origin, Point end)
        {
            this.origin = origin;
            this.end = end;
        }
        public override string ToString()
        {
            return "origin:" + this.origin + "\n" + "end:" + this.end;
        }
    }
}