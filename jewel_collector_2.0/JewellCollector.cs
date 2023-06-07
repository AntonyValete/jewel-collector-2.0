using System.Collections.ObjectModel;
namespace JewelCollector
{
    class JewelCollector
    {
        static void Main(string[] args)
        {
            // Criei uma collection dos game objects para conseguir renderizar no mapa a cada ação
            Collection<gameObject> gameObjectCollection = new Collection<gameObject>() {
                new RedJewel(1, 9, false, true),
                new RedJewel(8, 8, false, true),
                new GreenJewel(9, 1, false, true),
                new GreenJewel(7, 6, false, true),
                new BlueJewel(3, 4, false, true),
                new BlueJewel(2, 1, false, true),

                new Water(5, 0, false),
                new Water(5, 1, false),
                new Water(5, 2, false),
                new Water(5, 3, false),
                new Water(5, 4, false),
                new Water(5, 5, false),

                new Tree(5, 9, false),
                new Tree(3, 9, false),
                new Tree(8, 3, false),
                new Tree(2, 5, false),
                new Tree(1, 4, false)
            };

            // criei um robo de teste
            var testerbot = new Robot(1, 1, false, false, 100); // deixei em 100 para conseguir testar, dps muda
            ConsoleKeyInfo keyinfo; // definição da variavel da tecla pressionada
            bool gameRunning = true;
            var map = new Map(testerbot, gameObjectCollection);

            // Prototype declaration of the map array
            // TODO: implement this inside the Map class, outside of the Main function
            
            do
            {
                map.MapRender(map, gameObjectCollection);
                Console.Write("Energia: ");
                Console.WriteLine(testerbot.totalEnergy);
                
                Console.Write("Bag: ");
                foreach (Jewel item in testerbot.bag) {
                    Console.Write(item + " ");
                }
                
                Console.WriteLine("\n" + testerbot.getCoordinate()); // printa as novas coordenadas
                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey(); // lê o evento do teclado
                Console.WriteLine();
                testerbot.collectJewel(keyinfo.Key, map.map, gameObjectCollection);
                map.MovementEvent(keyinfo.Key, ref map, map.map, gameObjectCollection); // printa a tecla pressionada

                if (keyinfo.Key == ConsoleKey.X || keyinfo.Key == ConsoleKey.Q)
                    gameRunning = false; //eXit
                else if (testerbot.totalEnergy == 0)
                    gameRunning = false;
            } while (gameRunning == true);
        }
    }
}