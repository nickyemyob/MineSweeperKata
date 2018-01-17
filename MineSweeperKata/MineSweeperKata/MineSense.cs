using System;
using System.Collections.Generic;

namespace MineSweeperKata
{
    public class MineSense
    {
        public List<string> SetValueOnLeftOfMine(List<string> outputList, MineCoordinate mineCoordinate)
        {
            var mineAtEdgeOfFieldDetector = new MineAtEdgeOfFieldDetector();
            var top = outputList[mineCoordinate.Y].ToCharArray();
            if (mineAtEdgeOfFieldDetector.IsAtLeftEdge(mineCoordinate)) return outputList;

            int locationToUpdate;
            if (Int32.TryParse(top[mineCoordinate.X].ToString(), out locationToUpdate))
            {
                Console.WriteLine(locationToUpdate);
            }
            else
            {
                Console.WriteLine("is mine");
            }

            top[mineCoordinate.X] = (char)locationToUpdate;
            return outputList;
        }

        public List<string> SetValueOnTopOfMine(List<string> outputList, MineCoordinate mineCoordinate)
        {
            var mineAtEdgeOfFieldDetector = new MineAtEdgeOfFieldDetector();
            var top = outputList[mineCoordinate.Y + 1].ToCharArray();
            if (mineAtEdgeOfFieldDetector.IsAtTopEdge(mineCoordinate)) return outputList;

            int locationToUpdate;
            if (Int32.TryParse(top[mineCoordinate.X].ToString(), out locationToUpdate))
            {
                Console.WriteLine(locationToUpdate);
            }
            else
            {
                Console.WriteLine("is mine");
            }

            top[mineCoordinate.X] = (char)locationToUpdate;
            return outputList;
        }

        public List<string> SetValueOnTopLeftOfMine(List<string> outputList, MineCoordinate mineCoordinate)
        {
            var mineAtEdgeOfFieldDetector = new MineAtEdgeOfFieldDetector();
            var top = outputList[mineCoordinate.Y + 1].ToCharArray();
            if (mineAtEdgeOfFieldDetector.IsAtTopEdge(mineCoordinate)) return outputList;
            if (mineAtEdgeOfFieldDetector.IsAtLeftEdge(mineCoordinate)) return outputList;

            int locationToUpdate;
            if (Int32.TryParse(top[mineCoordinate.X - 1].ToString(), out locationToUpdate))
            {
                Console.WriteLine(locationToUpdate);
            }
            else
            {
                Console.WriteLine("is mine");
            }

            top[mineCoordinate.X - 1] = (char)locationToUpdate;
            return outputList;
        }
    }
}