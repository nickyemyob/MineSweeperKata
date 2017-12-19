using System;
using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        public Field Format(string input)
        {
            var lineSeparator = '\n';
            input = input.Substring(0, input.Length - 1);

            var field = new Field();
            var list = new List<string>();

            var fieldDetails = input.Split(lineSeparator);
            InputToField(field, list, fieldDetails);

            field.FieldLayout = list;
            return field;
        }

        private void InputToField(Field field, List<string> list, string[] fieldDetails)
        {
            foreach (var fieldDetail in fieldDetails)
            {
                if (fieldDetail.All(char.IsDigit))
                {
                    field.Width = CharToInt(fieldDetail[0]);
                    field.Height = CharToInt(fieldDetail[1]);
                }
                else
                {
                    list.Add(fieldDetail);
                }

            }
        }

        private int CharToInt(char c)
        {
            return (int)Char.GetNumericValue(c);
        }
    }
}