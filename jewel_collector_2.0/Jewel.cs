namespace JewelCollector
{
    public class RedJewel : gameObject
    {
        public static readonly string displayName = "RJ";
        public static readonly int value = 100;
        public RedJewel(int x, int y, bool passable, bool collectable) : base(x, y, passable, collectable) { }

        public string getDisplayName()
        {
            return RedJewel.displayName;
        }
    }
    public class GreenJewel : gameObject
    {
        public static readonly string displayName = "GJ";
        public static readonly int value = 50;
        public GreenJewel(int x, int y, bool passable, bool collectable) : base(x, y, passable, collectable) { }
    }
    public class BlueJewel : gameObject
    {
        public static readonly string displayName = "BJ";
        public static readonly int value = 10;
        public BlueJewel(int x, int y, bool passable, bool collectable) : base(x, y, passable, collectable) { }
    }
}