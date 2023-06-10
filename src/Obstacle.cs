namespace JewelCollector
{
    public abstract class Obstacle : gameObject
    {
        public Obstacle(int x, int y, bool collectable) : base(x, y, false, collectable) { }
    }

    public class Tree : Obstacle
    {
        private static string displayName = "$$";
        public static readonly int energyPoints = 3;
        public bool isCollected = false;

        public Tree(int x, int y, bool collectable) : base(x, y, collectable) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
    public class Water : Obstacle
    {
        private static string displayName = "##";
        public Water(int x, int y, bool collectable) : base(x, y, collectable) { }

        public override string getDisplayName()
        {
            return displayName;
        }
    }
    public class Radioactive : Obstacle
    {
        private static string displayName = "!!";
        public static readonly int energyPoints = -10;
        public Radioactive(int x, int y, bool collectable) : base(x, y, collectable) { }
        public override string getDisplayName()
        {
            return displayName;
        }
    }
}
