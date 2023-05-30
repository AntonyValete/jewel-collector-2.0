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
        public string displayName = "##";

        public Water(int x, int y, bool collectable) : base(x, y, collectable) { }
    }
}
