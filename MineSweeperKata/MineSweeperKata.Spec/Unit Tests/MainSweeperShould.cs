using System.Collections.Generic;
using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class MainSweeperShould
    {
        private static readonly object[] RawToProccessedObjects =
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
                "11\n" +
                "1*\n" +
                "\n" +
                "Field #2\n" +
                "000\n" +
                "011\n" +
                "01*\n"
            }

        };

        private static readonly object[] RawToExtractedDataObjects =
        {
            new object[]
            {
                "22\n" +
                "..\n" +
                ".*\n" +
                "00\n",

                new List<string>
                {
                    "..",
                    ".*"
                }
            },
            new object[]
            {
                "33\n" +
                "...\n" +
                "...\n" +
                "..*\n" +
                "00\n",

                new List<string>
                {
                    "...",
                    "...",
                    "..*"
                }
            }
        };

        [TestCaseSource(nameof(RawToExtractedDataObjects))]
        [Test]
        public void FormatInput(string input, IEnumerable<IEnumerable<char>> output)
        {

            
        }
        
    }
}