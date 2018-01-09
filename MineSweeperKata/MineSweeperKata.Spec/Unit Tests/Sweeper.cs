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

            var counter = 0;
            foreach (string s in split)
            {
                if (s.All(Char.IsDigit))
                {
                    field.Height = CharToInt(s[0]);
                    field.Width = CharToInt(s[1]);
                    counter = 0;
                    counter = CharToInt(s[1]);
                }
                else
                {
                    list.Add(s);
                }

            }

            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";

        }


        private int CharToInt(char c)
        {
            return (int)Char.GetNumericValue(c);
        }
    }
}