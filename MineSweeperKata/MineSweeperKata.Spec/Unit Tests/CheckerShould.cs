using System.Collections.Generic;
using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class CheckerShould
    {
        private static readonly object[] FieldObjects =
        {
            new object[]
            {
                new List<string>
                {
                    "..",
                    ".*"
                }
            }
        };

        [TestCaseSource(nameof(FieldObjects))]
        [Test]
        public void ReturnTrueIfMineIsNextToTheRightEdgeOfTheBoard(IEnumerable<IEnumerable<char>> inputField)
        {
            var field = inputField;
            var checker = new Checker();

            var isAtEdge = checker.IsAtEdge(field);

            Assert.True(isAtEdge);


        }

    }
}