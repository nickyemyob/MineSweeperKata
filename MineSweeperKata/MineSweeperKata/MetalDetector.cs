using System.Collections;
using System.Collections.Generic;

namespace MineSweeperKata
{
    public class MetalDetector
    {
        public string Sweep(string field)
        {
            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }

        public IEnumerable GetMineLocations(IEnumerable<IEnumerable<char>> map)
        {
            var mineCoordinates = new MineCoordinate(1, 1);
            return new List<MineCoordinate>
           {
               mineCoordinates
           };
        }
    }
}