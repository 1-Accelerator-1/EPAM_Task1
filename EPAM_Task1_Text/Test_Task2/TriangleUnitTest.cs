using EPAM_Task1.Task2;
using EPAM_Task1.Task2.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EPAM_Task1_Test.Test_Task2
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void Test_GetArea()
        {
            var sides = new List<double> { 6, 8, 10 };
            var triangle = new Triangle(sides);
            var result = triangle.GetArea();
            Assert.AreEqual(result, 24, 0.0000001);
        }

        [TestMethod]
        public void Test_GetPerimeter()
        {
            var points = new List<Point>
            {
                new Point(3, 2),
                new Point(5, 10),
                new Point(10, 3)
            };
            var triangle = new Triangle(points);
            var result = triangle.GetPerimeter();
            Assert.AreEqual(result, 23.91960433, 0.00000001);
        }
    }
}
