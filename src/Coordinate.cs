namespace JewelCollector
{
    /// <summary>
    /// Class: Coordinate class starter.
    /// </summary>
    public class Coordinate
    {
        private int x { get; set; }
        private int y { get; set; }

        /// <summary>
        /// Constructor: Coordinate constructor.
        /// </summary>
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Method: This will return the coordinates of given object.
        /// </summary>
        /// <returns>Int tuple: The coordinates of the given object.</returns>
        public (int, int) getCoordinate()
        {
            return (this.x, this.y);
        }

        /// <summary>
        /// Method: Set the coordinates of given object.
        /// </summary>
        public void setCoordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}