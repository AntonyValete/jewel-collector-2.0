namespace JewelCollector {
    public class Obstacle : gameObject {
        public passable = false;
    }

    public class Tree : Obstacle {
        public string displayName = "$$";
    }
    public class Water : Obstacle {
        public string displayName = "##";
    }
}
