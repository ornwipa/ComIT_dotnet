using measurable_objects;
namespace breakable_objects
{
    public interface Breakable
    {
        public bool isBroken();
    }

    public class Glass : Breakable,Measureble
    {
        private bool broken;
        public bool isBroken()
        {
            return this.broken;
        }
        public double calculateArea() { return 7; }
    }
}