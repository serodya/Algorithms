using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.Sorting;

namespace Codility.Sorting.Tests
{
    [TestClass]
    public class DistinctTests
    {
        [TestMethod]
        public void SolutionEmptyTest()
        {
            // Arrange
            int[] A = new int[] { };

            // Action
            int actual = Distinct.Solution(A);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int[] A = new int[] { 2, 1, 1, 2, 3, 1 };

            // Action
            int actual = Distinct.Solution(A);

            // Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleTwoValuesTest()
        {
            // Arrange
            int[] A = new int[] { 2, 2 };

            // Action
            int actual = Distinct.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }
    }
}
