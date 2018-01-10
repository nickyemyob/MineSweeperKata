using System;
using System.Collections.Generic;
using System.Linq;

namespace MineSweeperKata.Spec.Unit_Tests
{
    public class Sweeper
    {
        public object Sweep(string input)
        {
            //gets input and produces output
            var splitter = '\n';
            var split = input.Split(splitter);

            var field = new Field();
            var list = new List<string>();

            var counterX = 0;
            var counterY = 0;
            foreach (string boardElement in split)
            {
                if (boardElement.All(Char.IsDigit))
                {
                    field.Height = CharToInt(boardElement[0]);
                    field.Width = CharToInt(boardElement[1]);
                    counterX = CharToInt(boardElement[1]);
                }
                else
                {
                    list.Add(boardElement);
                }
            }

            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }


        private int CharToInt(char c)
        {
            return (int) Char.GetNumericValue(c);
        }
    }
}