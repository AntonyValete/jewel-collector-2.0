namespace JewelCollector {
    public class Coordinate {
        private int x {get; set;}        
        private int y {get; set;}

        public Coordinate(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public (int, int) getCoordinate() {
            return (this.x, this.y);
        }
        
        public void setCoordinate(int x, int y) {
            
            this.x = x;
            this.y = y;

        }
    }
}