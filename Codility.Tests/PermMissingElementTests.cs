using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.TimeComplexity;
using System.Collections.Generic;

namespace Codility.Tests
{
    [TestClass]
    public class PermMissingElementTests
    {
        [TestMethod]
        public void SolutionTest()
        {
            // Arrange
            int N = 100000;
            int[] A = new int[N];
            List<int> list = new List<int>();

            for (int i = 0; i < N + 1; i++)
            {
                list.Add(i + 1);
            }

            list.Remove(505);
            A = list.ToArray();

            // Action
            int actual = PermMissingElem.Solution(A);

            // Assert
            int expected = 505;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int[] A = new int[] { 1, 2, 4, 5, 6 };

            // Action
            int actual = PermMissingElem.Solution(A);

            // Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleEmptyTest()
        {
            // Arrange
            int[] A = new int[] { };

            // Action
            int actual = PermMissingElem.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
