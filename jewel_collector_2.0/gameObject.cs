namespace JewelCollector
{
    public class gameObject : Coordinate
    {
        public string displayName = "";
        public bool passable = true;
        public bool collectable = true;

        public gameObject(int x, int y) : base(x, y)
        {

        }
    }
}