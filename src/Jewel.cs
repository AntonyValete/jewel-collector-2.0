namespace JewelCollector
{
    public abstract class Jewel : gameObject
    {
        public Jewel(int x, int y) : base(x, y, false, true) { }
    }
    public class RedJewel : Jewel
    {
        private static readonly string displayName = "RJ";
        public static readonly int value = 100;
        public RedJewel(int x, int y) : base(x, y) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
    public class GreenJewel : Jewel
    {
        private static readonly string displayName = "GJ";
        public static readonly int value = 50;
        public GreenJewel(int x, int y) : base(x, y) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
    public class BlueJewel : Jewel
    {
        private static readonly string displayName = "BJ";
        public static readonly int value = 10;
        public static readonly int energyPoints = 5;
        public BlueJewel(int x, int y) : base(x, y) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
}