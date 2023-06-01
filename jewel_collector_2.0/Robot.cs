using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelCollector {

    
    public class Robot : Coordinate {   
        public static readonly string displayName = "ME";
        public int totalEnergy;
        public Robot(int x, int y, int totalEnergy): base(x, y) {
            setCoordinate(x, y);
            this.totalEnergy = totalEnergy;
        }

        public delegate void moveDelegateHandler();
        
        public event moveDelegateHandler gameEvent;

        
        public void Movement(ConsoleKey key) { // método de movimento vai mudar as coordenadas dependendo da tecla pressionada
            
            if (gameEvent != null) {
                
                (int x, int y) = this.getCoordinate();
                switch (key) {
                    case (ConsoleKey.A):
                        setCoordinate(x-1, y);
                        gameEvent();
                        break;
                    case (ConsoleKey.D):
                        setCoordinate(x+1, y);
                        gameEvent();
                        break;
                    case (ConsoleKey.S):
                        setCoordinate(x, y-1);
                        gameEvent();
                        break;
                    case (ConsoleKey.W):
                        setCoordinate(x, y+1);
                        gameEvent();
                        break;
                }

                
            }
        } 
    } 
}