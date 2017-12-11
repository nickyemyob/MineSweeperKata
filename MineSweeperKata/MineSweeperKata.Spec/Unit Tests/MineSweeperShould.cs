using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class MineSweeperShould
    {
        private static readonly object[] FieldObjects =
        {
            new object[]
            {
                "22\n" +
                "..\n" +
                ".*\n" +
                "00\n",

                "Field #1:\n" +
                "11\n" +
                "1*\n"
            }
        };

        [TestCaseSource(nameof(FieldObjects))]
        [Test]
        public void RevealMineAndDetectNearbyMines(string inputField, string expectedField)
        {
            var field = inputField;

            var expected = expectedField;

            var metalDetector = new MetalDetector();

            var actual = metalDetector.Detect(field);

            Assert.AreEqual(expected, actual);
        }
    }
}