using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector
{
    public class Robot : gameObject
    {
        public static readonly string displayName = "ME";
        public uint totalEnergy;
        public (int cx, int cy) coordCache;
        private (int dx, int dy) coordTemp;
        public Robot(int x, int y, bool passable, bool collectable, uint totalEnergy) : base(x, y, passable, collectable)
        {
            setCoordinate(x, y);
            this.totalEnergy = totalEnergy;
        }

        // TODO: Exception handler:
        public bool checkIfEmpty(int x, int y)
        {
            // Handling out of bounds check
            if (x < 0 || y < 0) return false;
            if (x > 9 || y > 9) return false;

            // TODO: Passable object checking
            // Pseudocode: If <object[coordTemp.x,coordTemp.y]> != passable return false;
            return true;
        }

        public void Movement(ConsoleKey key, ref Map map)
        { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada

            (int x, int y) = this.getCoordinate();
            (int dx, int dy) coordTemp = this.getCoordinate();
            switch (key)
            {
                case (ConsoleKey.A):
                    coordTemp = (x - 1, y);
                    break;
                case (ConsoleKey.D):
                    coordTemp = (x + 1, y);
                    break;
                case (ConsoleKey.S):
                    coordTemp = (x, y + 1);
                    break;
                case (ConsoleKey.W):
                    coordTemp = (x, y - 1);
                    break;
            }
            if (checkIfEmpty(coordTemp.dx, coordTemp.dy) == true)
            {
                coordCache = (x, y);
                setCoordinate(coordTemp.dx, coordTemp.dy);
                this.totalEnergy--;
            }
        }
        public override string getDisplayName()
        {
            return displayName;
        }
    }
}