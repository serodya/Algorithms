using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.BinaryGap;

namespace Codility.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void SolutionTest()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { -1, 3, -4, 5, 1, -6, 2, 1 };

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionTestExtremeLargeNumbers()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { 1082132608, 0, 1082132608 };

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionTestExtremeNegativeNumbers()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { -2147483648, -2147483648, -2147483648 };

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionTestForEmptyArray()
        {
            // Arrange
            Solution solution = new Solution();                          
            int[] a = new int[] { };

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = -1;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionTestForOneLarge()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { 500, 1, -2, -1, 2 };

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 0;
            Assert.AreEqual(expected, current);
        }        

        [TestMethod]
        public void SolutionTestPairOfOnes()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { -1, 1, -1, 1, 0};

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 4;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionOverflowTest2()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { 2147483647, 2147483647, 2147483647 };            

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 1;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionOverflowTest3()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[] { 0, 2147483647, 2147483647, 2147483647 };

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = 2;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void SolutionOverflowTest()
        {
            // Arrange
            Solution solution = new Solution();
            int[] a = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                a[i] = 2147483647;
            }            

            // Action
            int current = solution.solution(a);

            // Assert
            int expected = -1;
            Assert.AreEqual(expected, current);
        }
    }
}
