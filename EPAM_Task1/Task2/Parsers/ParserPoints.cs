using System.Collections.Generic;

namespace EPAM_Task1.Task2.Parsers
{
    /// <summary>
    /// Class for parsing points.
    /// </summary>
    public static class ParserPoints
    {
        /// <summary>
        /// The method parses a collection of strings into a list of points.
        /// </summary>
        /// <param name="coordsCollection">Point list for parsing</param>
        /// <returns>Point list</returns>
        public static List<Point> ParseToPoints(IReadOnlyList<string> coordsCollection)
        {
            var points = new List<Point>();
            for (int i = 0; i < coordsCollection.Count; i += 2)
            {
                points.Add(new Point(int.Parse(coordsCollection[i]), int.Parse(coordsCollection[i + 1])));
            }

            return points;
        }
    }
}
