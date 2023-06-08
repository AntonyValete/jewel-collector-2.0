using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JewelCollector {
    public class Robot : gameObject {   
        public static readonly string displayName = "ME";
        public int totalEnergy;
        public List<Jewel> bag = new List<Jewel>();
        public (int cx, int cy) coordCache;
        private (int dx, int dy) coordTemp;
        public delegate void moveDelegateHandler(Collection<gameObject> gameObjectCollection);
        public event moveDelegateHandler gameEvent;

        public Robot(int x, int y, bool passable, bool collectable, int totalEnergy) : base(x, y, passable, collectable) {
            setCoordinate(x, y);
            this.totalEnergy = totalEnergy;
        }

        // Novo método que cria um mini-mapa de obj com as coordenadas ao redor do robô
        public gameObject[,] checkAround(gameObject[,] map) {
            (int x, int y) = this.getCoordinate();
            gameObject [,] around = new gameObject[3,3];
            
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        try {
                            around[i,j] = map[y+(i-1), x+(j-1)];
                        } catch {
                            around[i,j] = null;
                        }
                        
                    }
                }
            
            return around;
        }

        // Novo método para coletar as gemas
        public void collectJewel(ConsoleKey key, gameObject[,] map, Collection<gameObject> gameObjectsCollection) {

            if (gameEvent != null) {
                if (key == ConsoleKey.G) {
                    gameObject[,] around = checkAround(map); // Cria um mini mapa de 3x3 com as coordenadas ao redor do robô
                    
                    for (int i = 0; i < around.GetLength(0); i++) { // Verifica se algum dos objetos ao redor é coletavel e, casi sim, o adiciona na bag e o remove da collection de objetos
                        for (int j = 0; j < around.GetLength(1); j++) {
                            try {
                                if (around[i, j] is Tree) {
                                    Console.WriteLine("energia!");
                                    this.totalEnergy += Tree.energyPoints;
                                }

                                if (around[i, j].getCollectable() == true) {
                                    if (around[i, j] is BlueJewel) {
                                        Console.WriteLine("energia!");
                                        this.totalEnergy += BlueJewel.energyPoints;
                                    }
                                    this.bag.Add((Jewel)around[i, j]);
                                    gameObjectsCollection.Remove(around[i, j]);
                                    gameEvent(gameObjectsCollection);
                                }

                            } catch { }             
                        }       
                    };
                }
            };

        }

        
        // TODO: Exception handler:
        public bool checkIfAllowed(int x, int y, gameObject[,] map) {
            if (x < 0 || y < 0 || x > 9 || y > 9) return false;
            if (map[y, x].getPassable() == false) return false;
            return true;
        }

        public void Movement(ConsoleKey key, ref Map map, gameObject[,] mapRender, Collection<gameObject> gameObjectsCollection) { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada
            
            if (gameEvent != null) {
                bool allowed = false;
                (int x, int y) = this.getCoordinate();
            	(int dx, int dy) coordTemp = this.getCoordinate();
                switch (key) {
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
                if (allowed) {
                    this.setCoordinate(x, y);
                    coordCache = (coordTemp.dx, coordTemp.dy); // suspeito que não precisa mais disso, mas vou deixar por enquanto
                    this.totalEnergy--;
                    gameEvent(gameObjectsCollection);
                } else {

                }
            }
        }
        public override string getDisplayName()
        {
            return displayName;
        }
    }
}