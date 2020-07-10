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
        /// <param name="coords">Point list for parsing</param>
        /// <returns>Point list</returns>
        public static List<Point> ParseToPoints(IReadOnlyList<string> coords)
        {
            var points = new List<Point>();
            for (int i = 0; i < coords.Count; i += 2)
            {
                points.Add(new Point(int.Parse(coords[i]), int.Parse(coords[i + 1])));
            }

            return points;
        }
    }
}
