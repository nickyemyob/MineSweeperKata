namespace MineSweeperKata
{
    public class FieldSpace
    {
        public FieldSpace()
        {
            Empty = '.';
            Mine = '*';
        }

        public char Empty { get; set; }
        public static char Mine { get; set; }
    }
}