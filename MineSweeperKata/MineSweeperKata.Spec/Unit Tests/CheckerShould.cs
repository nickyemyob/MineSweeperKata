using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class CheckerShould
    {
        private static readonly object[] MinesAtEdgeOfFieldScenarios =
        {
            new object[]
            {
                new MineCoordinate(1, 1),
                2,
                2
            }
        };

        [TestCaseSource(nameof(MinesAtEdgeOfFieldScenarios))]
        [Test]
        public void ReturnTrueIfMineIsNextToTheRightEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtRightEdge(mineLocation, fieldWidth, fieldHeight);

            Assert.True(isAtEdge);

        }

        private static readonly object[] MinesNotAtEdgeOfFieldScenarios =
        {
            new object[]
            {
                new MineCoordinate(1, 1),
                3,
                3
            }
        };

        [TestCaseSource(nameof(MinesNotAtEdgeOfFieldScenarios))]
        [Test]
        public void ReturnFalseIfMineIsNotNextToTheRightEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtRightEdge(mineLocation, fieldWidth, fieldHeight);

            Assert.False(isAtEdge);

        }

    }
}