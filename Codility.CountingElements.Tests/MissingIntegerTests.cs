using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.CountingElements;


namespace Codility.CountingElements.Tests
{
    [TestClass]
    public class MissingIntegerTests
    {
        [TestMethod]
        public void SolutionEmptyTest()
        {
            // Arrange
            int[] A = new int[] { };

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int[] A = new int[] { 1, 3, 6, 4, 1, 2 };

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionOneElementTest()
        {
            // Arrange
            int[] A = new int[] { 5 };

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionBigNumbersTest()
        {
            // Arrange
            int[] A = new int[] { -2147483648, 0, 1, 2, 3, 2147483647, 2147483647 };

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionNegativeNumbersOnlyTest()
        {
            // Arrange
            int[] A = new int[] { -4, -5, -3 };

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimplePositivesTest()
        {
            // Arrange
            int[] A = new int[] { 1, 2 };

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionOneHundredNumbersTest()
        {
            // Arrange
            int[] A = new int[100000];
            for (int i = 0; i < 100000; i++)
            {
                A[i] = i + 1;
            }

            // Action
            int actual = MissingInteger.Solution(A);

            // Assert
            int expected = 100001;
            Assert.AreEqual(expected, actual);
        }
    }
}
