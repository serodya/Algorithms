using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.PrefixSums;

namespace Codility.PrefixSums.Tests
{
    [TestClass]
    public class CountDivTests
    {
        [TestMethod]
        public void SolutionSimpleTest()
        {
            // Arrange
            int A = 6, B = 11, K = 2;

            // Action
            int actual = CountDiv.Solution(A, B, K);

            // Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleTwoTest()
        {
            // Arrange
            int A = 1, B = 2, K = 5;

            // Action
            int actual = CountDiv.Solution(A, B, K);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionSimpleThreeTest()
        {
            // Arrange
            int A = 1, B = 24, K = 5;

            // Action
            int actual = CountDiv.Solution(A, B, K);

            // Assert
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}
