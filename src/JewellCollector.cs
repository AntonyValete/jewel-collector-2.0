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

            ConsoleKeyInfo keyinfo;
            bool gameRunning = true;
            int gamePhase = 1;
            int mapDimension = 10;
            var map = new Map(new Robot(0, 0, 5), gameObjectCollection, mapDimension);
            int totalPoints = 0;

            do
            {
                map.mapRender(gameObjectCollection);

                Console.WriteLine($"Energia: {map.robot.totalEnergy}");
                Console.WriteLine($"Pontuação da fase: {map.robot.phasePoints}");
                Console.WriteLine($"Pontuação total: {totalPoints}");
                Console.Write("Bag: ");
                foreach (Jewel item in map.robot.bag)
                {
                    Console.Write(item.getDisplayName() + " ");
                }
                Console.WriteLine($"Fase: {gamePhase}");
                Console.WriteLine(map.robot.getCoordinate());

                Console.Write("Insira um movimento: ");
                keyinfo = Console.ReadKey();
                Console.WriteLine();
                map.robot.collectJewel(keyinfo.Key, map.map, gameObjectCollection);
                map.MovementEvent(keyinfo.Key, map.map, gameObjectCollection);

                if (!gameObjectCollection.OfType<Jewel>().Any())
                {
                    gamePhase++;
                    totalPoints += map.robot.phasePoints;
                    (map.robot, map, gameObjectCollection) = newphase(map);
                }

                if (keyinfo.Key == ConsoleKey.X || keyinfo.Key == ConsoleKey.Q || map.robot.totalEnergy <= 0)
                    gameRunning = false; //eXit
            } while (gameRunning == true);
        }


        /// <summary>
        /// Method: GetRandomCoordinates will generates unique tuples of coodinates given a range. This is helpful not to place gameObjects at the same spot.
        /// </summary>
        private static List<(int, int)> GetRandomCoordinates(int to, int numberOfElements, int from = 1)
        {
            Random rnd = new Random();
            HashSet<(int, int)> temp = new HashSet<(int, int)>();
            for (int i = 0; i < numberOfElements; i++)
                while (!temp.Add((rnd.Next(from, to), rnd.Next(from, to)))) ;
            return temp.ToList();
        }

        /// <summary>
        /// Method: newphase will generates a new phase of the game once all jewels had been collected from the last phase.
        /// </summary>
        static (Robot, Map, Collection<gameObject>) newphase(Map map)
        {
            Collection<gameObject> gameObjectCollection = new Collection<gameObject>() { };
            int mapDimension = map.map.GetLength(0) + 1;
            int Ratio = (mapDimension * mapDimension) * 18 / 100;
            int JewelRatio = (mapDimension * mapDimension) * 6 / 100;
            int ObstacleRatio = (mapDimension * mapDimension) * 11 / 100;
            int RadioactiveRatio = (mapDimension * mapDimension) * 1 / 100;
            var newBot = new Robot(0, 0, Ratio);

            var uniqueCoordinates = GetRandomCoordinates(mapDimension, Ratio);
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int x, y, type, j = 0;

            // Populate map with Jewel
            for (int i = 0; i < JewelRatio; i++)
            {
                type = rnd.Next(3);
                (x, y) = uniqueCoordinates[j++];
                switch (type)
                {
                    case 0:
                        gameObjectCollection.Add(new RedJewel(x, y));
                        break;
                    case 1:
                        gameObjectCollection.Add(new GreenJewel(x, y));
                        break;
                    case 2:
                        gameObjectCollection.Add(new BlueJewel(x, y));
                        break;
                }
            }
            for (int i = 0; i < ObstacleRatio; i++)
            {
                type = rnd.Next(2);
                (x, y) = uniqueCoordinates[j++];
                switch (type)
                {
                    case 0:
                        gameObjectCollection.Add(new Tree(x, y));
                        break;
                    case 1:
                        gameObjectCollection.Add(new Water(x, y));
                        break;
                }
            }
            for (int i = 0; i < RadioactiveRatio; i++)
            {
                (x, y) = uniqueCoordinates[j++];
                gameObjectCollection.Add(new Radioactive(x, y));
            }

            Map newMap = new Map(newBot, gameObjectCollection, mapDimension);
            return (newBot, newMap, gameObjectCollection);
        }
    }
}