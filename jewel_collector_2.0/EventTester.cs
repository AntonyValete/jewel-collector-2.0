namespace JewelCollector {
    class EventTester {

        public static void Main() {

            ConsoleKeyInfo keyinfo;
        do
        {
            keyinfo = Console.ReadKey();
            Console.WriteLine(keyinfo.Key + " was pressed");
        }

        while (keyinfo.Key != ConsoleKey.X);
            
        


        
        // public class Testerbot {

        //     (int x, int y) position = (1, 1);

        //     public event Movement(int x, int y) {
                
        //         Console.WriteLine("you moved!");
        //     }
            // public void testerbot(int x, int y) {
                
            //     position = (x, y);
            // }
        // }

        }
    }
}