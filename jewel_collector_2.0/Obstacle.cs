namespace JewelCollector
{
    public class Obstacle : gameObject
    {
        public Obstacle(int x, int y, bool collectable) : base(x, y, false, collectable) { }
    }

    public class Tree : Obstacle
    {
        public static string displayName = "$$";

        public Tree(int x, int y, bool collectable) : base(x, y, collectable) { }
    }
    public class Water : Obstacle
    {
        public static string displayName = "##";
        public static readonly int energyPoints = 3;

        public Water(int x, int y, bool collectable) : base(x, y, collectable) { }
    }
    public class Radioactive : Obstacle
    {
        public static string displayName = "!!";
        public static readonly int energyPoints = -10;
        public Radioactive(int x, int y, bool collectable) : base(x, y, collectable) { }
    }
}
