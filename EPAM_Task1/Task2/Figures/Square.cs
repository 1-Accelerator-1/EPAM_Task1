using System;
using System.Collections.Generic;
using System.Linq;

namespace EPAM_Task1.Task2.Figures
{
    /// <summary>
    /// Class for working with a square.
    /// </summary>
    public class Square : IFigure
    {
        public readonly List<double> Sides;

        /// <summary>
        /// Constructor to initialize a square through four points.
        /// </summary>
        /// <param name="points">Four points</param>
        public Square(IReadOnlyList<Point> points)
        {
            if (points.Count != 4)
            {
                throw new ArgumentException("The count of points is not equal to four.", "points");
            }

            Sides = new List<double>();
            Sides.Add(GetSide(points[0], points[1]));
        }

        /// <summary>
        /// Constructor to initialize a square through one or four sides.
        /// </summary>
        /// <param name="sides">One or four sides</param>
        public Square(IEnumerable<double> sides)
        {
            if (sides.Count() != 1 && sides.Count() != 4)
            {
                throw new ArgumentException("The count of sides is not equal to one or four.", "sides");
            }

            Sides = sides.ToList();
        }

        /// <inheritdoc cref="IFigure.GetArea()"/>
        public double GetArea()
        {
            return Sides[0] * Sides[0];
        }

        /// <inheritdoc cref="IFigure.GetPerimeter()"/>
        public double GetPerimeter()
        {
            return Sides[0] * 4;
        }

        /// <summary>
        /// Method for equal the current object with the specified object.
        /// </summary>
        /// <param name="obj">Any object</param>
        /// <returns>True or False</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Sides[0] == ((Square)obj).Sides[0];
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return Sides.GetHashCode() * 4;
        }

        /// <summary>
        /// The method creates and returns a string representation of the object.
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return string.Format($"Type Figure: {GetType().Name}\n" +
                                 $"Area: {GetArea()}\n" +
                                 $"Perimeter: {GetPerimeter()}");
        }

        /// <summary>
        /// The method calculates the distance between two specified points.
        /// </summary>
        /// <param name="point1">First point</param>
        /// <param name="point2">Second point</param>
        /// <returns>The distance between two specified points</returns>
        private double GetSide(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
    }
}
