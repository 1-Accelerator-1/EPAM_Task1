namespace EPAM_Task1.Task2
{
    /// <summary>
    /// Struct for working with point.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Constructor to initialize a point through coord X and coord Y.
        /// </summary>
        /// <param name="x">Coord X</param>
        /// <param name="y">Coord Y</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        /// <summary>
        /// Method for equal the current object with the specified struct.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }

            Point point = (Point)obj;

            return X == point.X && Y == point.Y;
        }

        /// <summary>
        /// The method calculates the hash code for the current struct.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return X ^ Y;
        }

        /// <summary>
        /// The method creates and returns a string representation of the struct.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return string.Format($"({X};{Y})");
        }
    }
}
