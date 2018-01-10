using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class SweeperShould
    {
        private static readonly object[] FieldAndSweepedFieldObjects =
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
            },
            new object[]
            {
                "33\n" +
                "...\n" +
                "...\n" +
                "..*\n" +
                "00\n",

                "Field #1:\n" +
                "000\n" +
                "011\n" +
                "01*\n"
            },
            new object[]
            {
                "22\n" +
                "..\n" +
                ".*\n" +
                "33\n" +
                "...\n" +
                "...\n" +
                "..*\n" +
                "00\n",

                "Field #1:\n" +
                "000\n" +
                "011\n" +
                "01*\n" +
                "\n" +
                "Field #2:\n" +
                "000\n" +
                "011\n" +
                "01*\n" +
                "00\n"

            }
        };

        [Test]
        public void RunTheSweepAndProduceOutput(string input, string output)
        {
            var sweeper = new Sweeper();
            var actualOutput = sweeper.Sweep(input);

            Assert.AreEqual(output, actualOutput);

        }
    }
}