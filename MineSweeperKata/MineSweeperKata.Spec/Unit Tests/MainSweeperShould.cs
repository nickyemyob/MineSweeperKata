using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    public class MainSweeperShould
    {
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
                "22\n" +
                "..\n" +
                ".*\n" +
                "00",

                "Field #1:\n" +
                "000\n" +
                "011\n" +
                "01*\n" +
                "\n" +
                "Field #2:\n" +
                "11\n" +
                "1*\n"
            }
        };

        [TestCaseSource(nameof(UserInputAndOutputScenarios))]
        [Test]
        [Ignore("first test")]
        public void RevealMineAndDetectNearbyMines(string inputField, string expectedField)
        {
            var mainSweeper = new MainSweeper();
            var actualOutput = mainSweeper.SweepField(inputField);

            Assert.AreEqual(expectedField, actualOutput);
        }
    }
}