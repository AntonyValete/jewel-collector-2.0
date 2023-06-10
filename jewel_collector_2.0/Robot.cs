using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JewelCollector
{

    /// <summary>
    /// Class: Robot class starter.
    /// </summary>
    public class Robot : gameObject
    {
        public static readonly string displayName = "ME";
        public int totalEnergy;
        public List<Jewel> bag = new List<Jewel>();
        public (int cx, int cy) coordCache;
        private (int dx, int dy) coordTemp;
        public delegate void moveDelegateHandler(Collection<gameObject> gameObjectCollection);
        public event moveDelegateHandler gameEvent;


        /// <summary>
        /// Object Constructor: Robot map constructor to create a new robot and position it into the map.
        /// </summary>
        public Robot(int x, int y, bool passable, bool collectable, int totalEnergy) : base(x, y, passable, collectable)
        {
            setCoordinate(x, y);
            this.totalEnergy = totalEnergy;
        }

        /// <summary>
        /// Object: checkAround method creates a 3x3 mini map to check the immediate surroundings of the robot.
        /// </summary>
        public gameObject[,] checkAround(gameObject[,] map)
        {
            (int x, int y) = this.getCoordinate();
            gameObject[,] around = new gameObject[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        around[i, j] = map[y + (i - 1), x + (j - 1)];
                    }
                    catch
                    {
                        around[i, j] = null;
                    }
                }
            }
            return around;
        }

        /// <summary>
        /// Method: The collectJewel method is responsable for collecting the Jewel or Energy from Obstacles. 
        /// It's important to notice that the Methods getCollected and setCollected will avoid the exploid of
        /// collecting energy infinite times from the Trees.
        /// </summary>
        public void collectJewel(ConsoleKey key, gameObject[,] map, Collection<gameObject> gameObjectsCollection)
        {

            if (gameEvent != null && key == ConsoleKey.G)
            {
                gameObject[,] around = checkAround(map);

                foreach (gameObject gObject in around)
                {
                    try
                    {
                        if (gObject is Tree && !gObject.getCollected())
                        {
                            Console.WriteLine("energia!");
                            this.totalEnergy += Tree.energyPoints;
                            gObject.setCollected(true);
                        }
                        else if (gObject.getCollectable())
                        {
                            if (gObject is BlueJewel)
                            {
                                Console.WriteLine("energia!");
                                this.totalEnergy += BlueJewel.energyPoints;
                            }
                            this.bag.Add((Jewel)gObject);
                            gameObjectsCollection.Remove(gObject);
                            gameEvent(gameObjectsCollection);
                        }
                    }
                    catch { }

                }
            }
        }

        /// <summary>
        /// Method: checkIfAllowed is the exception handler Method for the robot. This will return true if the robot is allowed to traverse to the next cell.
        /// </summary>
        public bool checkIfAllowed(int x, int y, gameObject[,] map)
        {
            if (x < 0 || y < 0 || x > (map.GetLength(0) - 1) || y > (map.GetLength(1) - 1)) return false;
            if (map[y, x].getPassable() == false) return false;
            return true;
        }

        /// <summary>
        /// Method: the Movement method will use the W,A,S,D keys to move the robot through the map, 
        /// calling the checkIfAllowed method to see if the robot is allowed to traverse to the next cell
        /// </summary>
        public void Movement(ConsoleKey key, ref Map map, gameObject[,] mapRender, Collection<gameObject> gameObjectsCollection)
        { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada

            if (gameEvent != null)
            {
                bool allowed = false;
                (int x, int y) = this.getCoordinate();
                (int dx, int dy) coordTemp = this.getCoordinate();
                switch (key)
                {
                    case (ConsoleKey.A):
                        x -= 1;
                        allowed = checkIfAllowed(x, y, mapRender);
                        break;
                    case (ConsoleKey.D):
                        x += 1;
                        allowed = checkIfAllowed(x, y, mapRender);
                        break;
                    case (ConsoleKey.S):
                        y += 1;
                        allowed = checkIfAllowed(x, y, mapRender);
                        break;
                    case (ConsoleKey.W):
                        y -= 1;
                        allowed = checkIfAllowed(x, y, mapRender);
                        break;
                }

                // check if next step is empty for movement
                if (allowed)
                {
                    this.setCoordinate(x, y);
                    coordCache = (coordTemp.dx, coordTemp.dy); // suspeito que não precisa mais disso, mas vou deixar por enquanto
                    this.totalEnergy--;
                    gameEvent(gameObjectsCollection);
                }
            }
        }

        /// <summary>
        /// Method: getDisplayName will return the display name for the object. This method is a helper to print the name of each gameObject in the map.
        /// </summary>
        public override string getDisplayName()
        {
            return displayName;
        }
    }
}