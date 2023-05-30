using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector {
    public class Robot : Coordinate {   


        public Robot(int x, int y): base(x, y) {
            setCoordinate(x, y);

        }
        public void Movement(ConsoleKey key) { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada
            
            (int x, int y) = this.getCoordinate();
            if (key == ConsoleKey.A) {

                setCoordinate(x-1, y);

            } else if (key == ConsoleKey.D) {

                setCoordinate(x+1, y);

            } else if (key == ConsoleKey.S) {

                setCoordinate(x, y-1);

            } else if (key == ConsoleKey.W) {

                setCoordinate(x, y+1);

            } else {
                
            }
        }
    }
}