using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class MineSweeperShould
    {
        [Test]
        public void RevealMineAndDetectNearbyMines()
        {
            var field = "22\n" +
                        "..\n" +
                        ".*\n" +
                        "00\n";

            var expected = "Field #1:\n" +
                         "11\n" +
                         "1*\n";

            var metalDetector = new MetalDetector();

            var actual = metalDetector.Detect(field);

            Assert.AreEqual(expected, actual);
        }
    }
}