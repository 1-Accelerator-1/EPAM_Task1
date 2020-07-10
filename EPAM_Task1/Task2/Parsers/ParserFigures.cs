using EPAM_Task1.Task2.Enums;
using EPAM_Task1.Task2.Figures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EPAM_Task1.Task2.Parsers
{
    /// <summary>
    /// Class for parsing figures.
    /// </summary>
    public static class ParserFigures
    {
        private const char Space = ' ';
        private const char Comma = ',';

        /// <summary>
        /// The method parses a collection of strings into a list of figures.
        /// </summary>
        /// <param name="textFiguresCollection">String collection for parsing</param>
        /// <returns>Figures List</returns>
        public static List<IFigure> ParseToArrayFigures(IEnumerable<string> textFiguresCollection)
        {
            List<IFigure> figures = new List<IFigure>();

            foreach (var textFigure in textFiguresCollection)
            {
                var figure = textFigure.Split(Space);
                var figureType = Enum.Parse(typeof(FigureTypes), figure[0]);

                switch (figureType)
                {
                    case FigureTypes.Square:
                        if (figure[1] == "points")
                        {
                            var coords = figure[2].Split(Comma);
                            var points = ParserPoints.ParseToPoints(coords);

                            figures.Add(new Square(points));
                        }
                        else
                        {
                            var textSides = figure[2].Split(Comma);
                            var sides = textSides.Select(obj => double.Parse(obj));
                            figures.Add(new Square(sides));
                        }
                        break;

                    case FigureTypes.Triangle:
                        if (figure[1] == "points")
                        {
                            var coords = figure[2].Split(Comma);
                            var points = ParserPoints.ParseToPoints(coords);

                            figures.Add(new Triangle(points));
                        }
                        else
                        {
                            var textSides = figure[2].Split(Comma);
                            var sides = textSides.Select(obj => double.Parse(obj));
                            figures.Add(new Triangle(sides));
                        }
                        break;

                    case FigureTypes.Rectangle:
                        if (figure[1] == "points")
                        {
                            var coords = figure[2].Split(Comma);
                            var points = ParserPoints.ParseToPoints(coords);

                            figures.Add(new Rectangle(points));
                        }
                        else
                        {
                            var textSides = figure[2].Split(Comma);
                            var sides = textSides.Select(obj => double.Parse(obj));
                            figures.Add(new Rectangle(sides));
                        }
                        break;

                    case FigureTypes.Circle:
                        if (figure[1] == "points")
                        {
                            var coords = figure[2].Split(Comma);
                            var points = ParserPoints.ParseToPoints(coords);

                            figures.Add(new Circle(points));
                        }
                        else
                        {
                            var radius = double.Parse(figure[2]);
                            figures.Add(new Circle(radius));
                        }
                        break;

                    default:
                        throw new ArgumentException();
                }
            }

            return figures;
        }
    }
}
