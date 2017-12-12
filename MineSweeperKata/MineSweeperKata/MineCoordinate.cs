namespace MineSweeperKata
{
    public class MineCoordinate
    {
        private int V1 { get; }
        private int V2 { get; }

        public MineCoordinate(int v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public override bool Equals(object obj)
        {
            return V1 == (obj as MineCoordinate).V1 &&
                   V2 == (obj as MineCoordinate).V2;
        }


        public override int GetHashCode()
        {
            unchecked
            {
                return (V1 * 397) ^ V2;
            }
        }
    }

}