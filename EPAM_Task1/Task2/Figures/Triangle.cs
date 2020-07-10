using System;
using System.Collections.Generic;
using System.Linq;

namespace EPAM_Task1.Task2.Figures
{
    /// <summary>
    /// Class for working with a triangle.
    /// </summary>
    public class Triangle : IFigure
    {
        public readonly List<double> Sides;

        /// <summary>
        /// Constructor to initialize a triangle through three points.
        /// </summary>
        /// <param name="pointsCollection">Three points</param>
        public Triangle(IReadOnlyList<Point> pointsCollection)
        {
            if (pointsCollection.Count != 3)
            {
                throw new ArgumentException("The count of points is not equal to three.", "points");
            }

            Sides = new List<double>();
            for (int i = 0; i < pointsCollection.Count; i++)
            {
                if (i == pointsCollection.Count - 1)
                {
                    Sides.Add(GetSide(pointsCollection[i], pointsCollection[0]));
                    break;
                }

                Sides.Add(GetSide(pointsCollection[i], pointsCollection[i + 1]));
            }
        }

        /// <summary>
        /// Constructor to initialize a square through one or three sides.
        /// </summary>
        /// <param name="sidesCollection">Three sides</param>
        public Triangle(IEnumerable<double> sidesCollection)
        {
            if (sidesCollection.Count() != 3)
            {
                throw new ArgumentException("The count of sides is not equal to three.", "sides");
            }

            Sides = sidesCollection.ToList();
        }

        /// <inheritdoc cref="IFigure.GetArea()"/>
        public double GetArea()
        {
            var halfPerimetr = GetPerimeter() / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - Sides[0]) * (halfPerimetr - Sides[1]) * (halfPerimetr - Sides[2]));
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

            Triangle triangle = (Triangle)obj;

            for (int i = 0; i < Sides.Count; i++)
            {
                if (Sides[i] != triangle.Sides[i])
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
            return Sides.GetHashCode() * 3;
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
