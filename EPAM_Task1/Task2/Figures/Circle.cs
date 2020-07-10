using System;
using System.Collections.Generic;

namespace EPAM_Task1.Task2.Figures
{
    /// <summary>
    /// Class for working with a circle.
    /// </summary>
    public class Circle : IFigure
    {
        public readonly double Radius;

        /// <summary>
        /// Constructor to initialize a circle through a radius.
        /// </summary>
        /// <param name="radius">Cicle radius</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The argument less or equal a zero.", "radius");
            }

            Radius = radius;
        }

        /// <summary>
        /// Constructor to initialize a circle through two points.
        /// </summary>
        /// <param name="pointsCollection">Two points: first point is center, second point is any point</param>
        public Circle(IReadOnlyList<Point> pointsCollection)
        {
            if (pointsCollection.Count != 2)
            {
                throw new ArgumentException("The count of points is not equal to two.", "points");
            }

            Radius = Math.Sqrt(Math.Pow(pointsCollection[0].X - pointsCollection[1].X, 2) + Math.Pow(pointsCollection[0].Y - pointsCollection[1].Y, 2));
        }

        /// <inheritdoc cref="IFigure.GetArea()"/>
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <inheritdoc cref="IFigure.GetPerimeter()"/>
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
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

            Circle circle = (Circle)obj;

            return Radius == circle.Radius;
        }

        /// <summary>
        /// The method calculates the hash code for the current object.
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            return Radius.GetHashCode() * 5;
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
    }
}
