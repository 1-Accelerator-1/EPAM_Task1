using EPAM_Task1.Task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM_Task1_Test.Test_Task1
{
    [TestClass]
    public class EuclidUnitTest
    {
        [TestMethod]
        public void GetGCDEuclid2_WithPositiveNumbers_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(252, 105);
            int actualResult = 21;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDEuclid2_WhenFirstNumberLessThenZero_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(-252, 105);
            int actualResult = 21;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDEuclid2_WhenFirstNumberEqualZero_GetSecondNumber()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(0, 105);
            int actualResult = 105;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDEuclid2_WhenTwoNumbersEqualsZero_GetZero()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(0, 0);
            int actualResult = 0;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDEuclid3_WithPositiveNumbers_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(252, 105, 147);
            int actualResult = 21;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDEuclid4_WithPositiveNumbers_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(250, 100, 150, 50);
            int actualResult = 50;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDEuclid5_WithPositiveNumbers_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDEuclid(98, 196, 441, 147, 1813);
            int actualResult = 49;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDStain_WithPositiveNumbers_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDStain(252, 105);
            int actualResult = 21;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDStain_WhenFirstNumberLessThenZero_GetGCD()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDStain(-252, 105);
            int actualResult = 21;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDStain_WhenSecondNumberEqualZero_GetFirstNumber()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDStain(252, 0);
            int actualResult = 252;
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void GetGCDStain_WhenTwoNumbersEqualsZero_GetZero()
        {
            Euclid euclid = new Euclid();
            int result = euclid.GetGCDStain(0, 0);
            int actualResult = 0;
            Assert.AreEqual(result, actualResult);
        }
    }
}
