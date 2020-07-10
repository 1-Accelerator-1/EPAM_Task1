using EPAM_Task1.Task2;
using EPAM_Task1.Task2.Figures;
using EPAM_Task1.Task2.FileWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EPAM_Task1_Test.Test_Task2
{
    [TestClass]
    public class FiguresCollectionUnitTest
    {
        [TestMethod]
        public void Test_GetFiguresEqualToGivenFigure()
        {
            var sides = new List<double> { 4 };
            var figuresCollection = new FiguresCollection(FileExtension.ReadData());
            var result = figuresCollection.GetFiguresEqualToGivenFigure(new Square(sides));
            var actualResult = new List<IFigure>
            {
                new Square(sides),
                new Square(sides),
                new Square(sides)
            };
            CollectionAssert.AreEqual(result, actualResult);
        }
    }
}
