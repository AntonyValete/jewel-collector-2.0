///
/// @file JewellCollector.cs
/// <summary>
/// Entry point for the JewelCollector Game
/// </summary>
/// @author Antony Valete
/// @author Lucas Mellone
/// @author Andrés García
/// @author Pedro Ferreira
/// @date 11/06/2023
/// $Id: JewellCollector.cs, v1.0 2023/06/11 $


using System.Collections.ObjectModel;
namespace JewelCollector
{
    class JewelCollector
    {
        static void Main(string[] args)
        {
            // Criei uma collection dos game objects para conseguir renderizar no mapa a cada ação
            Collection<gameObject> gameObjectCollection = new Collection<gameObject>() {
                new RedJewel(1, 9),
                new RedJewel(8, 8),
                new GreenJewel(9, 1),
                new GreenJewel(7, 6),
                new BlueJewel(3, 4),
                new BlueJewel(2, 1),

                new Water(5, 0),
                new Water(5, 1),
                new Water(5, 2),
                new Water(5, 3),
                new Water(5, 4),
                new Water(5, 5),

                new Tree(5, 9),
                new Tree(3, 9),
                new Tree(8, 3),
                new Tree(2, 5),
                new Tree(1, 4)
            };

            // criei um robo de teste
            var testerbot = new Robot(1, 1, 100); // deixei em 100 para conseguir testar, dps muda
            ConsoleKeyInfo keyinfo; // definição da variavel da tecla pressionada
            bool gameRunning = true;
            int gamePhase = 1;
            int mapDimension = 10;
            var map = new Map(testerbot, gameObjectCollection, mapDimension);

            do
            {
                map.Print(gameObjectCollection);

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Energia: ");
                Console.WriteLine(testerbot.totalEnergy);
                Console.Write("Bag: ");
                foreach (Jewel item in testerbot.bag)
                {
                    Console.Write(item.getDisplayName() + " ");
                }
                Console.Write($"Fase: {gamePhase}");

                Console.WriteLine("\n" + testerbot.getCoordinate()); // printa as novas coordenadas
                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey(); // lê o evento do teclado
                Console.WriteLine();
                testerbot.collectJewel(keyinfo.Key, map.map, gameObjectCollection);
                map.MovementEvent(keyinfo.Key, map.map, gameObjectCollection); // printa a tecla pressionada

                if (!gameObjectCollection.OfType<Jewel>().Any())
                {
                    gamePhase++;
                    (testerbot, map, gameObjectCollection) = newphase(map);
                }

                if (keyinfo.Key == ConsoleKey.X || keyinfo.Key == ConsoleKey.Q || testerbot.totalEnergy == 0)
                    gameRunning = false; //eXit
            } while (gameRunning == true);
        }

        static (Robot, Map, Collection<gameObject>) newphase(Map map)
        {

            var newBot = new Robot(1, 1, 100);
            int mapDimension = map.map.GetLength(0) + 1;

            Random rand = new Random(); // pensei em usar um random para colocar os novos objetos de maneira aleatória
            Collection<gameObject> gameObjectCollection = new Collection<gameObject>() {

            new RedJewel(1, 9),
            new RedJewel(8, 8),
            new GreenJewel(9, 1),
            new GreenJewel(7, 6),
            new BlueJewel(3, 4),
            new BlueJewel(2, 1),

            new Water(5, 0),
            new Water(5, 1),
            new Water(5, 2),
            new Water(5, 3),
            new Water(5, 4),
            new Water(5, 5),

            new Tree(5, 9),
            new Tree(3, 9),
            new Tree(8, 3),
            new Tree(2, 5),
            new Tree(1, 4),

            new Radioactive(9, 9)
            };

            Map newMap = new Map(newBot, gameObjectCollection, mapDimension);

            return (newBot, newMap, gameObjectCollection);

        }
    }
}