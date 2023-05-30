namespace JewelCollector
{
    public abstract class Jewel : gameObject
    {
        private string color;
        public Jewel(int x, int y, string displayName, bool passable, bool collectable) : base(x, y, displayName, passable, collectable) { }
    }
    public class RedJewel : Jewel
    {
        private static
        public RedJewel(int x, int y, string displayName, bool passable, bool collectable) : base(x, y, displayName, passable, collectable) { }
    }
    public class GreenJewel : Jewel
    {
        public string color = "Green";
        public int value = 50;
    }
    public class BlueJewel : Jewel
    {
        public string color = "Blue";
        public int value = 10;
    }
}