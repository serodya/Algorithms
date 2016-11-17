using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.BinaryGap;

namespace Codility.Tests
{
    [TestClass]
    public class MaxBinaryGapTest
    {
        [TestMethod]
        public void TestGetMaxBinaryGapWithBinary()
        {
            // Arrange
            var maxBinaryGap = new MaxBinaryGap();

            // Action
            var gap = maxBinaryGap.GetMaxBinaryGap(145);

            // Assert
            var expected = 3;
            Assert.AreEqual(expected, gap);
        }

        [TestMethod]
        public void TestGetMaxBinaryGap()
        {
            // Arrange
            var maxBinaryGap = new MaxBinaryGap();

            // Action
            var gap = maxBinaryGap.GetMaxBinaryGap(145);

            // Assert
            var expected = 3;
            Assert.AreEqual(expected, gap);
        }

        [TestMethod]
        public void TestGetMaxBinaryGapWithLinq()
        {
            // Arrange
            var maxBinaryGap = new MaxBinaryGap();

            // Action
            var gap = maxBinaryGap.GetMaxBinaryGapWithLinq(145);

            // Assert
            var expected = 3;
            Assert.AreEqual(expected, gap);
        }
    }
}
