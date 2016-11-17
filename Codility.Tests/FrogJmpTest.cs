using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.TimeComplexity;

namespace Codility.Tests
{
    [TestClass]
    public class FrogJmpTest
    {
        [TestMethod]
        public void SolutionTest()
        {
            // Arrange
            int X = 10, Y = 85, D = 30;

            // Action
            int actual = FrogJmp.Solution(X, Y, D);

            // Assert
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Solution2Test()
        {
            // Arrange
            int X = 10, Y = 70, D = 30;

            // Action
            int actual = FrogJmp.Solution(X, Y, D);

            // Assert
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
