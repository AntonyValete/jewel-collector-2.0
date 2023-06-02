namespace JewelCollector
{
    //It would be great if we could implement the singleton design pattern, but don't bother with it. Map and Robot
    public class Map
    {
        public gameObject[,] map;

        private Robot robot;
        public Map(Robot robot)
        {
            this.map = new gameObject[10, 10];

            // Populate the map with empty objects:
            for (int i = 0; i < this.map.GetLength(0); i++)
                for (int j = 0; j < this.map.GetLength(1); j++)
                    this.map[i, j] = new Empty(i, j, true, false);
            
            /* TODO: These are populating the map according to the instructions.
             * we should make a way of creating multiple instances of maps for
             * different stages.
             */
            this.map[1,9] = new RedJewel(1,9, false, true);
            this.map[8,8] = new RedJewel(8,8, false, true);
            this.map[9,1] = new GreenJewel(9,1, false, true);
            this.map[7,6] = new GreenJewel(7,6, false, true);
            this.map[3,4] = new BlueJewel(3,4, false, true);
            this.map[2,1] = new BlueJewel(2,1, false, true);
            
            this.map[5,0] = new Water(5, 0, false);
            this.map[5,1] = new Water(5, 1, false);
            this.map[5,2] = new Water(5, 2, false);
            this.map[5,3] = new Water(5, 3, false);
            this.map[5,4] = new Water(5, 4, false);
            this.map[5,5] = new Water(5, 5, false);

            this.map[5,9] = new Tree(5, 9, false);
            this.map[3,9] = new Tree(3, 9, false);
            this.map[8,3] = new Tree(8, 3, false);
            this.map[2,5] = new Tree(2, 5, false);
            this.map[1,4] = new Tree(1, 4, false);

            this.robot = robot;
        }

        public void SetRobotPosition() {
            (int x, int y) = robot.getCoordinate();
            this.map[robot.coordCache.cy, robot.coordCache.cx] = new Empty(robot.coordCache.cx, robot.coordCache.cy,true,false);
            this.map[y, x] = robot;
        }

        public void Print()
        {
            Console.Clear();
            for (int i = 0; i < this.map.GetLength(0); i++)
            {
                for (int j = 0; j < this.map.GetLength(1); j++)
                {
                    if (this.map[i,j] == robot) Console.ForegroundColor = ConsoleColor.Blue;
                    else if (this.map[i,j] != robot) Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(this.map[i, j].getDisplayName() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}