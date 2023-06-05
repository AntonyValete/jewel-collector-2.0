using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector {
    public class Robot : gameObject {   
        public static readonly string displayName = "ME";
        public uint totalEnergy;
        public (int cx, int cy) coordCache;
        private (int dx, int dy) coordTemp;
        public Robot(int x, int y, bool passable, bool collectable, uint totalEnergy) : base(x, y, passable, collectable) {
            setCoordinate(x, y);
            this.totalEnergy = totalEnergy;
        }
        
        // TODO: Exception handler:
        public bool checkIfAllowed(int x, int y, gameObject[,] map) {
            if (x < 0 || y < 0 || x > 9 || y > 9) return false;
            if (map[x, y].getPassable() == false) return false;
            // TODO: Passable object checking

            // Pseudocode: If <object[coordTemp.x,coordTemp.y]> != passable return false;
            return true;
        }

        public delegate void moveDelegateHandler();
        public event moveDelegateHandler gameEvent;

        public void Movement(ConsoleKey key, ref Map map, gameObject[,] mapRender) { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada
            
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
                    coordCache = (coordTemp.dx, coordTemp.dy);
                    this.totalEnergy--;
                    gameEvent();
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