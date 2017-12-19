using System.Collections;

namespace MineSweeperKata
{
    public class Field
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public IEnumerable FieldLayout { get; set; }
    }
}