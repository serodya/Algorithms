using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.BinaryGap;

namespace Codility.Tests
{
    [TestClass]
    public class CyclicRotationTests
    {
        [TestMethod]
        public void GetArrayRotatedTest()
        {
            // Arrange
            var cyclicRotation = new CyclicRotation();

            // Action
            var arrayRotated = cyclicRotation.GetArrayRotated(new int[] { 3, 8, 9, 7, 6 }, 3);

            // Assert
            int[] expected = new int[] { 9, 7, 6, 3, 8 };
            CollectionAssert.AreEqual(expected, arrayRotated);
        }
    }
}
