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
        public void Movement(ConsoleKey key) { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada
            
            (int x, int y) = this.getCoordinate();
            switch (key) {
                case (ConsoleKey.A):
                    setCoordinate(x-1, y);
                    break;
                case (ConsoleKey.D):
                    setCoordinate(x+1, y);
                    break;
                case (ConsoleKey.S):
                    setCoordinate(x, y-1);
                    break;
                case (ConsoleKey.W):
                    setCoordinate(x, y+1);
                    break;
            }
        }
    }
}