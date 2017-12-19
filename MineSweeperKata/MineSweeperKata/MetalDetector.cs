using System;
using System.Collections;
using System.Collections.Generic;

namespace MineSweeperKata
{
    public class MetalDetector
    {
        private const char Mine = '*';

        public string Sweep(string field)
        {
            return "Field #1:\n" +
                   "11\n" +
                   "1*\n";
        }

        public IEnumerable GetMineLocations(Field map)
        {
            var x = 0;
            var y = 0;

            var mineCoordinates = new List<MineCoordinate>();

            foreach (var yMap in map.FieldLayout)
            {
                foreach (var xMap in yMap)
                {
                    if (xMap == Mine)
                    {
                        mineCoordinates.Add(new MineCoordinate(x, y));
                    }

                    x++;
                }
                x = 0;
                y++;

            }

            return mineCoordinates;
        }
    }
}