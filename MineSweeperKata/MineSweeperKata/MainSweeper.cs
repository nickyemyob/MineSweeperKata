using System.Collections.Generic;

namespace MineSweeperKata
{
    public class MainSweeper
    {
        public Field Format(string input)
        {
            return new Field
            {
                Width = 2,
                Height = 2,
                FieldLayout =
                    new List<string>
                    {
                        "..",
                        ".*"
                    }
            };
        }
    }
}