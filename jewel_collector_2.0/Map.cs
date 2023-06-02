namespace JewelCollector
{
    //It would be great if we could implement the singleton design pattern, but don't bother with it. Map and Robot
    public class Map
    {
        private gameObject[,] map;

        private Robot robot;

        public Map(Robot robot)
        {
            this.map = new gameObject[3, 3];
            this.robot = robot;
        }

        //This method need to be used within another method in order to change the position of the robot.
        private void Swap(ref gameObject A, ref gameObject B)
        {
            gameObject temp = A;
            A = B;
            B = temp;
        }

        public void Print()
        {
            for (int i = 0; i < this.map.GetLength(0); i++)
            {
                for (int j = 0; j < this.map.GetLength(1); j++)
                {
                    Console.Write(this.map[i, j].getDisplayName());
                }
                Console.WriteLine();
            }
        }
    }
}