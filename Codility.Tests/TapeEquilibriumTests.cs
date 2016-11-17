using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.BinaryGap;

namespace Codility.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        public void GetTapeEquilibriumMinimumEmptyTest()
        {
            // Arrange
            TapeEquilibrium tapeEquilibrium = new TapeEquilibrium();
            int[] tape = new int[] { };

            // Action
            var current = tapeEquilibrium.GetTapeEquilibriumMinimum(tape);

            // Assert
            var expected = 0;
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public void GetTapeEquilibriumMinimumExtremeLargeTest()
        {
            // Arrange
            TapeEquilibrium tapeEquilibrium = new TapeEquilibrium();
            int[] tape = new int[] { 1082132608, 1082132608, 1082132608, 1082132608, 1082132608 };

            // Action
            var current = tapeEquilibrium.GetTapeEquilibriumMinimum(tape);

            // Assert
            var expected = 1082132608;
            Assert.AreEqual(expected, current);
        }
    }
}
