using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.CountingElements;

namespace Codility.CountingElements.Tests
{
    [TestClass]
    public class FrogRiverOneTests
    {
        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int[] A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            int X = 5;

            // Action
            int actual = FrogRiverOne.Solution(X, A);

            // Assert
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionEmptyTest()
        {
            // Arrange
            int[] A = new int[] { };
            int X = 5;

            // Action
            int actual = FrogRiverOne.Solution(X, A);

            // Assert
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionFrogCantCrossTest()
        {
            // Arrange
            int[] A = new int[] { 1, 1, 1, 1 };
            int X = 5;

            // Action
            int actual = FrogRiverOne.Solution(X, A);

            // Assert
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionFrogCanCrossBigNumbersTest()
        {
            // Arrange
            int X = 100000;
            int[] A = new int[X];
            

            for (int i = 0; i < X; i++)
            {
                A[i] = i + 1;
            }

            // Action
            int actual = FrogRiverOne.Solution(X, A);

            // Assert
            int expected = 99999;
            Assert.AreEqual(expected, actual);
        }
    }
}
