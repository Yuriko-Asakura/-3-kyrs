using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLibrary;
namespace MyLibrary.Tests
{
    [TestClass]
    public class MathUtilsTests
    {
        private static double[] emptyArray;

        [ClassInitialize]
        public static void InitializeClass(TestContext context)
        {
            emptyArray = new double[0];
        }

        [TestMethod]
        public void CalculateRoots_DiscriminantLessThanZero_ReturnsEmptyArray()
        {
            double[] roots = MaLi.CalculateRoots(1, 2, 5);
            double[] expectedArray = new double[0];
            CollectionAssert.AreEqual(expectedArray, roots);
        }

        [TestMethod]
        public void CalculateRoots_DiscriminantEqualToZero_ReturnsSingleRoot()
        {
            double[] roots = MaLi.CalculateRoots(1, -2, 1);
            CollectionAssert.AreEqual(new double[] { 1 }, roots);
        }

        [TestMethod]
        public void CalculateRoots_DiscriminantGreaterThanZero_ReturnsTwoRoots()
        {
            double[] roots = MaLi.CalculateRoots(1, -3, 2);
            CollectionAssert.AreEqual(new double[] { 2, 1 }, roots);
        }

        [TestMethod]
        public void CalculatePercentage_WithDelta()
        {
            double delta = 0.0001;
            string a = delta.ToString();

            double result = MaLi.CalculatePercentage(99.5, 10.5);
            double[] expectedResult = new double[] { 10.44751 };
            CollectionAssert.AreEqual(expectedResult, new double[] { result }, a);

        }
    }
}

