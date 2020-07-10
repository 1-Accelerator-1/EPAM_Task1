using EPAM_Task1.Task2;
using EPAM_Task1.Task2.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_Task1_Test.Test_Task2
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod]
        public void Test_GetArea()
        {
            var sides = new List<double> { 6, 8, 6, 8 };
            var rectangle = new Rectangle(sides);
            var result = rectangle.GetArea();
            Assert.AreEqual(result, 48, 0.0000001);
        }

        [TestMethod]
        public void Test_GetPerimeter()
        {
            var points = new List<Point>
            {
                new Point(2, 2),
                new Point(2, 4),
                new Point(7, 4),
                new Point(7, 2)
            };
            var rectangle = new Rectangle(points);
            var result = rectangle.GetPerimeter();
            Assert.AreEqual(result, 14, 0.0000001);
        }
    }
}
