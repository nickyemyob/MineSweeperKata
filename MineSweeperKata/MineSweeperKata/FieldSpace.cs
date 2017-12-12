namespace MineSweeperKata
{
    public class FieldSpace
    {
        public FieldSpace()
        {
            Empty = '.';
            Mine = '*';
        }

        public static char Empty { get; set; }
        public static char Mine { get; set; }
    }
}