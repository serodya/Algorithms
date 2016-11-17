using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.BinaryGap;

namespace Codility.Tests
{
    [TestClass]
    public class OddOcurrencesInArrayTest
    {
        [TestMethod]
        public void GetUnpairedElementTest()
        {
            // Arrange
            int[] a = new int[] { 2, 3, 2, 3, 7 , 7, 9};
            var oddOcurrencesInArray = new OddOccurrencesInArray();

            // Action
            int result = oddOcurrencesInArray.GetUnpairedElement(a);

            // Assert
            int expected = 9;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetUnpairedElementWithXORTest()
        {
            // Arrange
            int[] a = new int[] { 2, 3, 2, 3, 7, 7, 425 };
            var oddOcurrencesInArray = new OddOccurrencesInArray();

            // Action
            int result = oddOcurrencesInArray.GetUnpairedElementWithXOR(a);

            // Assert
            int expected = 425;
            Assert.AreEqual(expected, result);
        }
    }
}
