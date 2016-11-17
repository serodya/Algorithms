using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.PrefixSums;

namespace Codility.PrefixSums.Tests
{
    [TestClass]
    public class PassingCarsTests
    {
        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int[] A = new int[] { 0, 1, 0, 1, 0, 1, 0 };

            // Action
            int actual = PassingCars.Solution(A);

            // Assert
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionExcedingMaxTest()
        {
            // Arrange
            int[] A = new int[100000];
            for (int i = 0; i < 30000; i++)
            {
                A[i] = i % 2 == 0 ? 0 : 1;
            }

            for (int i = 30000; i < 100000; i++)
            {
                A[i] = 1;
            }

            // Action
            int actual = PassingCars.Solution(A);

            // Assert
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }
    }
}
