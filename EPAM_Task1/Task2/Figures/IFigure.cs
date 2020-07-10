namespace EPAM_Task1.Task2.Figures
{
    /// <summary>
    /// An interface that defines the methods that the heir must implement.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// The method calculates the perimeter of the current figure.
        /// </summary>
        /// <returns>Perimeter</returns>
        public double GetPerimeter();

        /// <summary>
        /// The method calculates the area of the current figure.
        /// </summary>
        /// <returns>Area</returns>
        public double GetArea();
    }
}
