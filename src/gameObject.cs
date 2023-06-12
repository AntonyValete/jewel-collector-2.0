namespace JewelCollector
{
    /// <summary>
    /// Class: gameObject class starter. Inherits from Coordinate.
    /// </summary>
    public abstract class gameObject : Coordinate
    {

        private bool passable { get; set; }
        private bool collectable { get; set; }
        private bool isCollected { get; set; }

        /// <summary>
        /// Constructor: gameObject constructor.
        /// </summary>
        public gameObject(int x, int y, bool passable, bool collectable) : base(x, y)
        {
            this.passable = passable;
            this.collectable = collectable;
        }

        /// <summary>
        /// Abstract method: getDisplayName is abstract method that has to be implemented in all direct subclasses. This helps to garantee that all subclasses has this implementation.
        /// </summary>
        /// <returns>String: Object display name.</returns>
        public abstract string getDisplayName();

        /// <summary>
        /// Method: getPassable will return the passable attribute to the caller.
        /// </summary>
        /// <returns>Bool: Object passable attribute.</returns>
        public bool getPassable()
        {
            return this.passable;
        }

        /// <summary>
        /// Method: getCollectable will return the passable attribute to the caller.
        /// </summary>
        /// <returns>Bool: Object collectable attribute.</returns>
        public bool getCollectable()
        {
            return this.collectable;
        }

        /// <summary>
        /// Method: getCollected will return the passable attribute to the caller.
        /// </summary>
        /// <returns>Bool: Object collected attribute.</returns>
        public bool getCollected()
        {
            return this.isCollected;
        }

        /// <summary>
        /// Method: setCollected will set the collected attribute.
        /// </summary>
        public void setCollected(bool Collected)
        {
            this.isCollected = Collected;
        }
    }

    /// <summary>
    /// Class: Empty (--) class starter. Inherits from gameObject class.
    /// </summary>
    public class Empty : gameObject
    {
        private static readonly string displayName = "--";

        /// <summary>
        /// Constructor: Empty constructor.
        /// </summary>
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