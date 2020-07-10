using EPAM_Task1.Task2.Figures;
using System.Collections.Generic;
using System.Linq;

namespace EPAM_Task1.Task2
{
    /// <summary>
    /// Class for working with collection of figures.
    /// </summary>
    public class FiguresCollection
    {
        private List<IFigure> _figures;

        /// <summary>
        /// Constructor to initialize figure collcetion.
        /// </summary>
        /// <param name="figures">Figure collcetion</param>
        public FiguresCollection(IEnumerable<IFigure> figures)
        {
            _figures = figures.ToList();
        }

        /// <summary>
        /// The method selects figures equal to the given one and returns their list.
        /// </summary>
        /// <param name="figure">Any figure</param>
        /// <returns>Figure collcetion</returns>
        public List<IFigure> GetFiguresEqualToGivenFigure(IFigure figure) => _figures.Where(obj => obj.Equals(figure)).ToList();
    }
}
