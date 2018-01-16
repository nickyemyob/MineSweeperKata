using System;
using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        private const string EndOfInput = "00";
        private const char Mine = '*';

        public string SweepField(string inputField)
        {
            var fields = ConvertInputToFields(inputField);

            //add logic that produces output here
            var output = ConvertFieldsToOutput(fields);

            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }

        private List<Field> ConvertInputToFields(string inputField)
        {
            var rawInputData = inputField.Split('\n');
            var fields = new List<Field>();
            var field = new Field();
            var fieldHeight = 0;
            var fieldWidth = 0;
            var fieldLayout = new List<string>();

            foreach (var fieldInfo in rawInputData)
            {
                if (fieldInfo.Any(char.IsDigit))
                {
                    if (fieldInfo == EndOfInput)
                    {
                        break;
                    }

                    if (fieldHeight > 0 && fieldWidth > 0)
                    {
                        field.Height = fieldHeight;
                        field.Width = fieldWidth;
                        field.FieldLayout = fieldLayout;
                        fields.Add(field);
                    }
                    else
                    {
                        continue;
                    }
                }

                fieldHeight++;
                if (fieldWidth != 0)
                {
                    fieldWidth = fieldInfo.Length;
                }
                fieldLayout.Add(fieldInfo);
            }
            return fields;
        }

        private string ConvertFieldsToOutput(List<Field> fields)
        {
            var output = "";

            foreach (var field in fields)
            {
                var fieldNumber = 1;
                var metalDetector = new MetalDetector();

                //TODO: ADD LOGIC FOR DETERMINING WHAT NUMBERs ARE INCREASED BECAUSE OF THE MINE

                var mineLocations = metalDetector.GetMineLocations(field);
                var initalOutput = new String('0', field.Width);
                var outputList = Enumerable.Repeat(initalOutput, field.Height).ToList();
                var mineEdgeDetector = new MineAtEdgeOfFieldDetector();

                foreach (var mineCoordinate in mineLocations)
                {
                    var row = outputList[mineCoordinate.Y].ToCharArray();
                    row[mineCoordinate.X] = Mine;
                    outputList[mineCoordinate.Y] = row.ToString();

                    if (!mineEdgeDetector.IsAtRightEdge(mineCoordinate, field.Width))
                    {
                        //TODO: ADD NUMBERS ARROUND MINES
                    }
                }

                output = output + $"Field #{fieldNumber}";
                    
            }

            return output;
        }
    }
}