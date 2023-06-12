namespace JewelCollector
{
    /// <summary>
    /// Class: Jewel class starter. Inherits from gameObject.
    /// </summary>
    public abstract class Jewel : gameObject
    {
        public readonly int value;

        /// <summary>
        /// Constructor: Jewel constructor.
        /// </summary>
        public Jewel(int x, int y, int value) : base(x, y, false, true) { this.value = value; }
    }

    /// <summary>
    /// Class: Class RedJewel starter. Inherits from Jewel.
    /// </summary>
    public class RedJewel : Jewel
    {
        private static readonly string displayName = "RJ";
        private static readonly int value = 100;

        /// <summary>
        /// Constructor: RedJewel constructor.
        /// </summary>
        public RedJewel(int x, int y) : base(x, y, value) { }


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
    /// Class: Class GreenJewel starter. Inherits from Jewel.
    /// </summary>
    public class GreenJewel : Jewel
    {
        private static readonly string displayName = "GJ";
        private static readonly int value = 50;

        /// <summary>
        /// Constructor: GreenJewel constructor.
        /// </summary>
        public GreenJewel(int x, int y) : base(x, y, value) { }

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
    /// Class: Class BlueJewel starter. Inherits from Jewel.
    /// </summary>
    public class BlueJewel : Jewel
    {
        private static readonly string displayName = "BJ";
        private static readonly int value = 10;
        public static readonly int energyPoints = 5;

        /// <summary>
        /// Constructor: BlueJewel constructor.
        /// </summary>
        public BlueJewel(int x, int y) : base(x, y, value) { }

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