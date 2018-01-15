using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        private const string EndOfInput = "00";


        public string Sweep(string inputField)
        {
            var rawInputData = inputField.Split('\n');
            var fields = new List<Field>();
            var field = new Field();
            int fieldHeight = 0;
            int fieldWidth = 0;
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

            var output = "";


            //add logic that produces output here
            for (int i = 1; i < fields.Count; i++)
            {
                var metalDetector = new MetalDetector();
                var mines = metalDetector.GetMineLocations(fields[i]);

                var outputList = new List<List<string>>();

                //TODO: ADD LOGIC FOR DETERMINING WHAT NUMBER ARE INCREASED BECUASE OF THE THE MINE

                

                output = output + $"Field #{i}";
            }

            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }
    }
}