namespace JewelCollector
{
    /// <summary>
    /// Class: Jewel class starter.
    /// </summary>
    public abstract class Jewel : gameObject
    {
        public readonly int value;
        public Jewel(int x, int y, int value) : base(x, y, false, true) { this.value = value; }
    }
    public class RedJewel : Jewel
    {
        private static readonly string displayName = "RJ";
        private static readonly int value = 100;
        public RedJewel(int x, int y) : base(x, y, value) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
    public class GreenJewel : Jewel
    {
        private static readonly string displayName = "GJ";
        private static readonly int value = 50;
        public GreenJewel(int x, int y) : base(x, y, value) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
    public class BlueJewel : Jewel
    {
        private static readonly string displayName = "BJ";
        private static readonly int value = 10;
        public static readonly int energyPoints = 5;
        public BlueJewel(int x, int y) : base(x, y, value) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
}