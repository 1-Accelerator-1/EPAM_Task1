using System;
using System.Collections.Generic;
using System.Linq;

namespace EPAM_Task1.Task2.Figures
{
    /// <summary>
    /// Class for working with a rectangle.
    /// </summary>
    public class Rectangle : IFigure
    {
        public readonly List<double> Sides;

        /// <summary>
        /// Constructor to initialize a rectangle through four points.
        /// </summary>
        /// <param name="points">Four points</param>
        public Rectangle(IReadOnlyList<Point> points)
        {
            if (points.Count != 4)
            {
                throw new ArgumentException("The count of points is not equal to four.", "points");
            }

            Sides = new List<double>();
            for (int i = 0; i < points.Count; i++)
            {
                if (i == points.Count - 1)
                {
                    Sides.Add(GetSide(points[i], points[0]));
                    break;
                }

                Sides.Add(GetSide(points[i], points[i + 1]));
            }
        }

        /// <summary>
        /// Constructor to initialize a rectangle through two or four sides.
        /// </summary>
        /// <param name="sides">Two or four sides</param>
        public Rectangle(IEnumerable<double> sides)
        {
            if (sides.Count() != 2 && sides.Count() != 4)
            {
                throw new ArgumentException("The count of sides is not equal to two or four.", "sides");
            }

            Sides = sides.ToList();
        }

        /// <inheritdoc cref="IFigure.GetArea()"/>
        public double GetArea()
        {
            return Sides[0] * Sides[1];
        }

        /// <inheritdoc cref="IFigure.GetPerimeter()"/>
        public double GetPerimeter()
        {
            return Sides.Sum();
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

            Rectangle rectangle = (Rectangle)obj;

            for (int i = 0; i < Sides.Count; i++)
            {
                if (Sides[i] != rectangle.Sides[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return Sides.GetHashCode() * 2;
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
