namespace JewelCollector
{
    /// <summary>
    /// Class: Obstacle class starter. Inherits from gameObject class.
    /// </summary>
    public abstract class Obstacle : gameObject
    {
        /// <summary>
        /// Constructor: Obstacle constructor.
        /// </summary>
        public Obstacle(int x, int y, bool collectable) : base(x, y, false, collectable) { }
    }

    /// <summary>
    /// Class: Tree class starter. Inherits from Obstacle class.
    /// </summary>
    public class Tree : Obstacle
    {
        private static string displayName = "$$";
        public static readonly int energyPoints = 3;
        public bool isCollected = false;

        /// <summary>
        /// Constructor: Tree constructor.
        /// </summary>
        public Tree(int x, int y, bool collectable) : base(x, y, collectable) { }

        /// <summary>
        /// Method: getDisplayName will return the display name for the object. This method is a helper to print the name of each gameObject in the map.
        /// </summary>
        /// <returns>String: Object display name.</returns>
        public override string getDisplayName()
        {
            return displayName;
        }
    }

    /// <summary>
    /// Class: Water class starter. Inherits from Obstacle class.
    /// </summary>
    public class Water : Obstacle
    {
        private static string displayName = "##";

        /// <summary>
        /// Constructor: Water constructor.
        /// </summary>
        public Water(int x, int y, bool collectable) : base(x, y, collectable) { }


        /// <summary>
        /// Method: getDisplayName will return the display name for the object. This method is a helper to print the name of each gameObject in the map.
        /// </summary>
        /// <returns>String: Object display name.</returns>
        public override string getDisplayName()
        {
            return displayName;
        }
    }

    /// <summary>
    /// Class: Radioactive class starter. Inherits from Obstacle class.
    /// </summary>
    public class Radioactive : Obstacle
    {
        private static string displayName = "!!";
        public static readonly int energyPoints = -10;

        /// <summary>
        /// Constructor: Radioactive constructor.
        /// </summary>
        public Radioactive(int x, int y, bool collectable) : base(x, y, collectable) { }

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
