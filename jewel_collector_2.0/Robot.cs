using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector {
    public class Robot : Coordinate {   
        public static readonly string displayName = "ME";
        public uint totalEnergy;
        public Robot(int x, int y, uint totalEnergy): base(x, y) {
            setCoordinate(x, y);
            this.totalEnergy = totalEnergy;
        }
        
        // TODO: Exception handler:
        public bool checkIfEmpty(int x, int y) {
            return true;
        }

        public void Movement(ConsoleKey key) { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada
            
            (int x, int y) = this.getCoordinate();
            (int dx, int dy) coord_temp = (0, 0);
            switch (key) {
                case (ConsoleKey.A):
                    coord_temp = (x-1, y);
                    break;
                case (ConsoleKey.D):
                    coord_temp = (x+1, y);
                    break;
                case (ConsoleKey.S):
                    coord_temp = (x, y+1);
                    break;
                case (ConsoleKey.W):
                    coord_temp = (x, y-1);
                    break;
            }
            if (checkIfEmpty(coord_temp.dx, coord_temp.dy) == true) {
                setCoordinate(coord_temp.dx, coord_temp.dy);
                this.totalEnergy--;
            }
        }
    }
}