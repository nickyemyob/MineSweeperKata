using System.Collections;
using System.Collections.Generic;

namespace MineSweeperKata
{
    public class Field
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public IEnumerable<string> FieldLayout { get; set; }
    }
}