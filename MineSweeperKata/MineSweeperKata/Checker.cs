namespace MineSweeperKata
{
    public class Checker
    {
        public bool IsAtRightEdge(MineCoordinate mineLocation, int fieldWidth, int fieldHeight)
        {
            return mineLocation.X == fieldWidth - 1;
        }
    }
}