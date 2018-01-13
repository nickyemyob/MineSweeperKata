using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    public class MainSweeperShould
    {
        //        [TestCaseSource(nameof(FieldAndSweepedFieldObjects))]
        //        [Ignore("top test")]
        //        [Test]
        //        public void RevealMineAndDetectNearbyMines(string inputField, string expectedField)
        //        {
        //            var field = inputField;
        //
        //            var expected = expectedField;
        //
        //            var metalDetector = new MetalDetector();
        //
        //            var actual = metalDetector.Sweep(field);
        //
        //            Assert.AreEqual(expected, actual);
        //        }

        private static readonly object[] UserInputAndOutputScenarios =
        {
            new object[]
            {
                "22\n" +
                "..\n" +
                ".*\n" +
                "00",

                "Field #1:\n" +
                "11\n" +
                "1*\n"
            },
            
            new object[]
            {
                "33\n" +
                "...\n" +
                "...\n" +
                "..*\n" +
                "00",

                "Field #1:\n" +
                "000\n" +
                "011\n" +
                "01*\n"
            },
            
            new object[]
            {
                "33\n" +
                "...\n" +
                "...\n" +
                "..*\n" +
                "00",

                "Field #1:\n" +
                "000\n" +
                "011\n" +
                "01*\n"
            }
        };

        [TestCaseSource(nameof(UserInputAndOutputScenarios))]
        [Test]
        public void RevealMineAndDetectNearbyMines(string inputField, string ExpectedField)
        {
            var expectedOutput = ExpectedField;
            var mainSweeper = new MainSweeper();
            var actualOutput = mainSweeper.Sweep();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}