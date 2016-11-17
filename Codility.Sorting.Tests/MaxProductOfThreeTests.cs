using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Sorting.Tests
{
    [TestClass]
    public class MaxProductOfThreeTests
    {
        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int[] A = new int[] { -3, 1, 2, -2, 5, 6 };

            // Action
            int actual = MaxProductOfThree.Solution(A);

            // Assert
            int expected = 60;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionBigNumbersTest()
        {
            // Arrange
            int[] A = new int[] { -3, 1, 2, 1000, 1000, 1000 };

            // Action
            int actual = MaxProductOfThree.Solution(A);

            // Assert
            int expected = 1000000000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionLongArrayTest()
        {
            // Arrange
            int[] A = new int[1001];
            for (int i = 0; i < 1000; i++)
            {
                A[i] = -1 * (1000 - i);
            }
            A[1000] = 1;

            // Action
            int actual = MaxProductOfThree.Solution(A);

            // Assert
            int expected = 999000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionNegativeAndPositiveTest()
        {
            // Arrange
            int[] A = new int[] { -5, -4, -3, -2, 0, 2, 2, 3};

            // Action
            int actual = MaxProductOfThree.Solution(A);

            // Assert
            int expected = 60;
            Assert.AreEqual(expected, actual);
        }
    }
}
