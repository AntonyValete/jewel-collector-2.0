namespace JewelCollector {
    public class map {

        //TODO
        private void Swap(gameObject A, gameObject B) {

        }
        public static void Print(string[,] mapArray, Robot robot) {

            (int x, int y) = robot.getCoordinate();
            mapArray[y, x] = Robot.displayName;

            for (int i = 0; i < mapArray.GetLength(0); i++) {
                for (int j = 0; j < mapArray.GetLength(1); j++) {
                    Console.Write(mapArray[i,j] + " ");
                }
                Console.Write("\n");
            }  
        }
    }
}