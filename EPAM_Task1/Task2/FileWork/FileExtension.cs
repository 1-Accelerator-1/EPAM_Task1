using EPAM_Task1.Task2.Figures;
using EPAM_Task1.Task2.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EPAM_Task1.Task2.FileWork
{
    /// <summary>
    /// Class for wirking with file.
    /// </summary>
    public static class FileExtension
    {
        /// <summary>
        /// The method reads data from a file and returns a list of figures.
        /// </summary>
        /// <returns>Figure list</returns>
        public static List<IFigure> ReadData()
        {
            using (var streamReader = new StreamReader(@"..\..\..\..\EPAM_Task1\Task2\Resources\Figures.txt", Encoding.Default))
            {
                string line;
                var textFigures = new List<string>();
                while ((line = streamReader.ReadLine()) != null)
                {
                    textFigures.Add(line);
                }

                var figures = ParserFigures.ParseToArrayFigures(textFigures);

                return figures;
            }
        }
    }
}
