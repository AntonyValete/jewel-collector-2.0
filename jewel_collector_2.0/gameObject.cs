namespace JewelCollector
{
    public class gameObject : Coordinate
    {
        private bool passable { get; set; }
        private bool collectable { get; set; }

        public gameObject(int x, int y, bool passable, bool collectable) : base(x, y)
        {
            this.passable = passable;
            this.collectable = collectable;
        }
    }
}