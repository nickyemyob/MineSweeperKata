namespace MineSweeperKata
{
    public class Checker
    {
        public bool IsAtRightEdge(MineCoordinate mineLocation, int fieldWidth, int fieldHeight)
        {
            return mineLocation.X == fieldWidth - 1;
        }

        public bool IsAtLeftEdge(MineCoordinate mineLocation, int fieldWidth, int fieldHeight)
        {
            return mineLocation.X == 0;
        }

        public bool IsAtTopEdge(MineCoordinate mineLocation, int fieldWidth, int fieldHeight)
        {
            return mineLocation.Y == 0;
        }

        public bool IsAtBottomEdge(MineCoordinate mineLocation, int fieldWidth, int fieldHeight)
        {
            return mineLocation.Y == fieldHeight;
        }
    }
}