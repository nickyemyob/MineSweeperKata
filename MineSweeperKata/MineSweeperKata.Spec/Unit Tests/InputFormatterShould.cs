using System.Collections.Generic;
using NUnit.Framework;

namespace MineSweeperKata.Spec.Unit_Tests
{
    [TestFixture]
    public class InputFormatterShould
    {
        private static readonly object[] RawToExtractedDataObjects =
        {
            new object[]
            {
                "22\n" +
                "..\n" +
                ".*\n",

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
                }
            },
            new object[]
            {
                "33\n" +
                "...\n" +
                "...\n" +
                "..*\n",

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
                    
                }
            }

        };

        [TestCaseSource(nameof(RawToExtractedDataObjects))]
        [Test]
        public void FormatInput(string input, Field expectedField)
        {
            var formatter = new InputFormatter();
            var actualField = formatter.Format(input);

            CollectionAssert.AreEqual(expectedField.FieldLayout, actualField.FieldLayout);
            Assert.AreEqual(expectedField.Height, actualField.Height);
            Assert.AreEqual(expectedField.Width, actualField.Width);

        }
        
    }
}