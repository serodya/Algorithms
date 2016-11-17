using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.CountingElements;

namespace Codility.CountingElements.Tests
{
    [TestClass]
    public class PermCheckTests
    {
        [TestMethod]
        public void SolutionEmptyTest()
        {
            // Arrange
            int[] A = new int[] { };

            // Action
            int actual = PermCheck.Solution(A);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimplePermutationTest()
        {
            // Arrange
            int[] A = new int[] { 4, 1, 3, 2 };

            // Action
            int actual = PermCheck.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleNoPermutationTest()
        {
            // Arrange
            int[] A = new int[] { 4, 1, 3 };

            // Action
            int actual = PermCheck.Solution(A);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionOneHundredNumbersPermutationTest()
        {
            // Arrange
            int length = 100000;
            int[] A = new int[length];
            for (int i = 0; i < length; i++)
            {
                A[i] = i + 1;
            }

            // Action
            int actual = PermCheck.Solution(A);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionBigNumbersTest()
        {
            // Arrange
            int length = 100000;
            int[] A = new int[length];
            for (int i = 0; i < length - 10; i++)
            {
                A[i] = i + 1;
            }
            for (int i = length - 10; i < length; i++)
            {
                A[i] = 1000000000 - i;
            }

            // Action
            int actual = PermCheck.Solution(A);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
