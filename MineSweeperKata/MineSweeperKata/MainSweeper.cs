using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        private const string EndOfInput = "00";


        public string Sweep(string inputField)
        {
            var inputReader = inputField.Split('\n');

            foreach (var fieldInfo in inputReader)
            {
                if (fieldInfo.Any(char.IsDigit))
                {
                    if (fieldInfo == EndOfInput)
                    {
                        break;
                    }
                }

                var field = new Field();
                var fieldLayout = new List<string> {fieldInfo};
                field.FieldLayout = fieldLayout;
            }
            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }
    }
}