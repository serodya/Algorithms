using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.StacksAndQueues.Tests
{
    [TestClass]
    public class BracketsTests
    {
        [TestMethod]
        public void SolutionNoNestedTest()
        {
            // Arrange
            string s = "([)()]";

            // Action
            int actual = Brackets.Solution(s);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionNestedTest()
        {
            // Arrange
            string s = "([()()]{})";

            // Action
            int actual = Brackets.Solution(s);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SolutionStartingWithOpenBracketTest()
        {
            // Arrange
            string s = ")(";

            // Action
            int actual = Brackets.Solution(s);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
