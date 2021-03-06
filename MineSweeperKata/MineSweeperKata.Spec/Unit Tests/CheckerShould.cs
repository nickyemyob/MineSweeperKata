﻿using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class CheckerShould
    {
        private static readonly object[] MinesAtRightEdgeOfFieldScenarios =
        {
            new object[]
            {
                new MineCoordinate(1, 1),
                2,
                2
            }
        };

        [TestCaseSource(nameof(MinesAtRightEdgeOfFieldScenarios))]
        [Test]
        public void ReturnTrueIfMineIsNextToTheRightEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtRightEdge(mineLocation, fieldWidth);

            Assert.True(isAtEdge);

        }

        private static readonly object[] MinesAtLeftEdgeOfFieldScenarios =
        {
            new object[]
            {
                new MineCoordinate(0, 0),
                2,
                2
            },

            new object[]
            {
                new MineCoordinate(0, 1),
                2,
                2
            }
        };

        [TestCaseSource(nameof(MinesAtLeftEdgeOfFieldScenarios))]
        [Test]
        public void ReturnTrueIfMineIsNextToTheLeftEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtLeftEdge(mineLocation);

            Assert.True(isAtEdge);

        }

        private static readonly object[] MinesAtTopEdgeOfFieldScenarios =
        {
            new object[]
            {
                new MineCoordinate(0, 0),
                2,
                2
            },

            new object[]
            {
                new MineCoordinate(1, 0),
                2,
                2
            }
        };

        [TestCaseSource(nameof(MinesAtTopEdgeOfFieldScenarios))]
        [Test]
        public void ReturnTrueIfMineIsNextToTheTopEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtTopEdge(mineLocation);

            Assert.True(isAtEdge);

        }

        private static readonly object[] MinesAtBottomEdgeOfFieldScenarios =
        {
            new object[]
            {
                new MineCoordinate(0, 1),
                2,
                2
            },

            new object[]
            {
                new MineCoordinate(1, 1),
                2,
                2
            }
        };

        [TestCaseSource(nameof(MinesAtBottomEdgeOfFieldScenarios))]
        [Test]
        public void ReturnTrueIfMineIsNextToTheBottomEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtBottomEdge(mineLocation, fieldHeight);

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

            var isAtEdge = checker.IsAtRightEdge(mineLocation, fieldWidth);

            Assert.False(isAtEdge);

        }

        [TestCaseSource(nameof(MinesNotAtEdgeOfFieldScenarios))]
        [Test]
        public void ReturnFalseIfMineIsNotNextToTheLeftEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtLeftEdge(mineLocation);

            Assert.False(isAtEdge);

        }

        [TestCaseSource(nameof(MinesNotAtEdgeOfFieldScenarios))]
        [Test]
        public void ReturnFalseIfMineIsNotNextToTheTopEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtTopEdge(mineLocation);

            Assert.False(isAtEdge);

        }

        [TestCaseSource(nameof(MinesNotAtEdgeOfFieldScenarios))]
        [Test]
        public void ReturnFalseIfMineIsNotNextToTheBottomEdgeOfTheBoard(MineCoordinate inputtedMineLocation, int fieldWidth, int fieldHeight)
        {
            var mineLocation = inputtedMineLocation;
            var checker = new Checker();

            var isAtEdge = checker.IsAtBottomEdge(mineLocation, fieldHeight);

            Assert.False(isAtEdge);

        }

    }
}