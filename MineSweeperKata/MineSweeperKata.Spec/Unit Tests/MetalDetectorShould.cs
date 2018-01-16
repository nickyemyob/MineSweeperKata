using System.Collections.Generic;
using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class MetalDetectorShould
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
//            var actual = metalDetector.SweepField(field);
//
//            Assert.AreEqual(expected, actual);
//        }

        private static readonly object[] MapObjects =
        {
            new object[]
            {
                new Field
                {
                    Width = 2,
                    Height = 2,
                    FieldLayout =
                        new List<string>
                        {
                            "..",
                            ".*"
                        }
                },
                new List<MineCoordinate>
                {
                    new MineCoordinate(1, 1)
                }
            },

            new object[]
            {
                new Field
                {
                    Width = 3,
                    Height = 3,
                    FieldLayout =
                        new List<string>
                        {
                            "...",
                            "...",
                            "..*"
                        }
                },
                new List<MineCoordinate>
                {
                    new MineCoordinate(2, 2)
                }
            },
        };

        [TestCaseSource(nameof(MapObjects))]
        [Test]
        public void GetMineLocations(Field map, IList<MineCoordinate> expectCoordinates)
        {
            var metalDetector = new MetalDetector();

            var actualCoordinates = metalDetector.GetMineLocations(map);

            Assert.That(actualCoordinates, Is.EquivalentTo(expectCoordinates));
        }
    }
}