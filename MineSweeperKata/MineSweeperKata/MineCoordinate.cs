namespace MineSweeperKata
{
    public class MineCoordinate
    {
        public int X { get; }
        public int Y { get; }

        public MineCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return X == (obj as MineCoordinate).X &&
                   Y == (obj as MineCoordinate).Y;
        }


        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }

}