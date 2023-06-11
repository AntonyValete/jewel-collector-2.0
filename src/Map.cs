using System.Collections.ObjectModel;

namespace JewelCollector
{
    //It would be great if we could implement the singleton design pattern, but don't bother with it. Map and Robot
    public class Map
    {
        public gameObject[,] map;
        private Robot robot;

        public Map(Robot robot, Collection<gameObject> gameObjectCollection, int mapDimension)
        {
            this.map = new gameObject[mapDimension, mapDimension];
            robot.gameEvent += Print;
            this.robot = robot;
        }

        public void Print(Collection<gameObject> gameObjectCollection) // Agora a cada movimento o print renderiza e insere os objetos no mapa
        {
            Console.Clear();
            // TODO: Aqui não seria melhor criar um outro método chamado PopulateMap(Collection<gameObject> gameObjectCollection);?
            for (int i = 0; i < this.map.GetLength(0); i++)
            {
                for (int j = 0; j < this.map.GetLength(1); j++)
                {
                    foreach (gameObject gObject in gameObjectCollection)
                    {
                        // Verifica se na collection existe um objeto nas coordenadas específicas e, caso sim, o insere no mapa
                        if (gObject.getCoordinate() == (i, j))
                        {
                            this.map[i, j] = gObject;
                            break;
                        }
                        else if (robot.getCoordinate() == (i, j))
                        {
                            this.map[i, j] = robot;
                            break;
                        }
                        this.map[i, j] = new Empty(i, j);
                    }
                }
            }

            // Aqui printa
            for (int i = 0; i < this.map.GetLength(0); i++)
            {
                for (int j = 0; j < this.map.GetLength(1); j++)
                {
                    switch (map[i, j].getDisplayName())
                    {
                        case "ME":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "BJ":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "RJ":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "GJ":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "$$":
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case "##":
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case "!!":
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case "--":
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }
                    // else if (this.map[i, j] != robot) Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(this.map[i, j].getDisplayName() + " ");
                }
                Console.WriteLine();
            }
        }

        public void MovementEvent(ConsoleKey key, gameObject[,] mapRender, Collection<gameObject> gameObjectsCollection)
        {
            robot.Movement(key, mapRender, gameObjectsCollection);
        }

        public void MapRender(Map map, Collection<gameObject> gameObjectCollection)
        {
            map.Print(gameObjectCollection);
        }
    }
}