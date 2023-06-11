namespace JewelCollector
{
    /// <summary>
    /// Class: gameObject class starter. Inherits from Coordinate.
    /// </summary>
    public abstract class gameObject : Coordinate
    {
        public readonly int energyPoints;

        private bool passable { get; set; }
        private bool collectable { get; set; }
        private bool isCollected { get; set; }

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
        public bool getCollected() {
            return this.isCollected;
        }
        public bool setCollected(bool Collected) {
            return this.isCollected = Collected;
        }
    }

    /// <summary>
    /// Class: Empty (--) class starter. Inherits from gameObject class.
    /// </summary>
    public class Empty : gameObject
    {
        private static readonly string displayName = "--";
        public Empty(int x, int y, bool passable, bool collectable) : base(x, y, passable, collectable) { }

        /// <summary>
        /// Method: getDisplayName will return the display name for the object. This method is a helper to print the name of each gameObject in the map.
        /// </summary>
        /// <returns>String: Object display name.</returns>
        public override string getDisplayName()
        {
            return displayName;
        }
    }
}