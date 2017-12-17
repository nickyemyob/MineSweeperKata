namespace MineSweeperKata
{
    public class Checker
    {
        public bool IsAtRightEdge(MineCoordinate mineLocation, int fieldWidth)
        {
            return mineLocation.X == fieldWidth - 1;
        }

        public bool IsAtLeftEdge(MineCoordinate mineLocation)
        {
            return mineLocation.X == 0;
        }

        public bool IsAtTopEdge(MineCoordinate mineLocation)
        {
            return mineLocation.Y == 0;
        }

        public bool IsAtBottomEdge(MineCoordinate mineLocation, int fieldHeight)
        {
            return mineLocation.Y == fieldHeight;
        }
    }
}