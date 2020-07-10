using EPAM_Task1.Task2;
using EPAM_Task1.Task2.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EPAM_Task1_Test.Test_Task2
{
    [TestClass]
    public class SquareUnitTest
    {
        [TestMethod]
        public void Test_GetArea()
        {
            var sides = new List<double> { 5 };
            var square = new Square(sides);
            var result = square.GetArea();
            Assert.AreEqual(result, 25, 0.0000001);
        }

        [TestMethod]
        public void Test_GetPerimeter()
        {
            var points = new List<Point>
            {
                new Point(1, 1),
                new Point(1, 5),
                new Point(5, 5),
                new Point(5, 1)
            };
            var square = new Square(points);
            var result = square.GetPerimeter();
            Assert.AreEqual(result, 16, 0.0000001);
        }
    }
}
