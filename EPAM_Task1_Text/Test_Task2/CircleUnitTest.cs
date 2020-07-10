using EPAM_Task1.Task2;
using EPAM_Task1.Task2.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EPAM_Task1_Test.Test_Task2
{
    [TestClass]
    public class CircleUnitTest
    {
        [TestMethod]
        public void Test_GetArea()
        {
            var circle = new Circle(5);
            var result = circle.GetArea();
            Assert.AreEqual(result, 78.5398163, 0.0000001);
        }

        [TestMethod]
        public void Test_GetPerimeter()
        {
            var points = new List<Point>
            {
                new Point(10, 10),
                new Point(10, 17)
            };
            var circle = new Circle(points);
            var result = circle.GetPerimeter();
            Assert.AreEqual(result, 43.9822971, 0.0000001);
        }
    }
}
