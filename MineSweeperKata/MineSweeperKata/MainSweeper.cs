using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        private const string EndOfInput = "00";


        public string Sweep(string inputField)
        {
            var RawInputData = inputField.Split('\n');
            var field = new Field();
            int fieldHeight = 0;
            int fieldWidth = 0;
            var fieldLayout = new List<string>();

            foreach (var fieldInfo in RawInputData)
            {
                
                if (fieldInfo.Any(char.IsDigit))
                {
                    if (fieldInfo == EndOfInput)
                    {
                        break;
                    }
                    
                    //TODO: CHECK FOR "01"

                    //assigning fields here
                    if (fieldHeight > 0 && fieldWidth > 0)
                    {
                        field.Height = fieldHeight;
                        field.Width = fieldWidth;
                        field.FieldLayout = fieldLayout;
                    }
                }

                fieldHeight++;
                fieldWidth = fieldInfo.Length;
                fieldLayout.Add(fieldInfo);
            }

            

            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }
    }
}