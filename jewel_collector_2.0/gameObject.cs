namespace JewelCollector
{
    public abstract class gameObject : Coordinate
    {
        private bool passable { get; set; }
        private bool collectable { get; set; }

        public gameObject(int x, int y, bool passable, bool collectable) : base(x, y)
        {
            this.passable = passable;
            this.collectable = collectable;
        }

        public abstract string getDisplayName();
        public bool getPassable() {
            return this.passable;
        }
        public bool getCollectable() {
            return this.collectable;
        }
    }

    public class Empty : gameObject
    {
        private static readonly string displayName = "--";
        public Empty(int x, int y, bool passable, bool collectable) : base(x, y, passable, collectable) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
}