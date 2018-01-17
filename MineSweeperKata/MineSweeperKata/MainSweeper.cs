using System;
using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        private readonly MineSense _mineSense = new MineSense();
        private const string EndOfInput = "00";
        private const char Mine = '*';

        public string SweepField(string inputField)
        {
            var fields = ConvertInputToFields(inputField);

            return ConvertFieldsToOutput(fields);

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
                output = output + $"Field #{fieldNumber}\n";

                var mineLocations = metalDetector.GetMineLocations(field);
                var initalOutput = new String('0', field.Width);
                var outputList = Enumerable.Repeat(initalOutput, field.Height).ToList();

                foreach (var mineCoordinate in mineLocations)
                {
                    var row = outputList[mineCoordinate.Y].ToCharArray();
                    row[mineCoordinate.X] = Mine;
                    outputList[mineCoordinate.Y] = row.ToString();


                    //TODO: ADD NUMBERS ARROUND MINES
                    outputList = _mineSense.SetValueOnTopOfMine(outputList, mineCoordinate);
//                    outputList = SetValueOnTopRightOfMine(outputList, mineCoordinate);
//                    outputList = SetValueOnRightOfMine(outputList, mineCoordinate);
//                    outputList = SetValueOnBottomRightOfMine(outputList, mineCoordinate);
//                    outputList = SetValueOnBottomOfMine(outputList, mineCoordinate);
//                    outputList = SetValueOnBottomLeftOfMine(outputList, mineCoordinate);
                    outputList = _mineSense.SetValueOnLeftOfMine(outputList, mineCoordinate);
                    outputList = _mineSense.SetValueOnTopLeftOfMine(outputList, mineCoordinate);

                }

                foreach (var fieldOutput in outputList)
                {
                    output = output + fieldOutput + "\n";
                }
                    
            }

            return output;
        }
    }
}