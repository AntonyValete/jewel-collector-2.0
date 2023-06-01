namespace JewelCollector {
    public class Map {
        public static void Print() {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Console.Write("##");
                }
                Console.Write("\n");
            }  
        }

        
        
        
        // public void ExemploKeyEventHandler() {
        //     robotester.Movement();
        // }
    }
    public class subscriptorEvent {
            ConsoleKey key;
            Robot robotest;

            public void Print() {
                Console.Write("\n");
                for (int i = 0; i < 10; i++) {
                    for (int j = 0; j < 10; j++) {
                        Console.Write("##");
                    }
                    Console.Write("\n");
                }  
        }
            // public void 

            public subscriptorEvent() {
                robotest = new Robot(1, 1, 10);

                robotest.gameEvent += Print;
            }

            public void MovementEvent(ConsoleKey key) {
                robotest.Movement(key);
            }

            public (int, int) robotCoordinate() {
                return robotest.getCoordinate();
            }

            public void MapRender() {
                Map.Print();
            }

    }

    
}