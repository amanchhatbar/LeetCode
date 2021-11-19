using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class IslandCount
    {
        string[,] matrix ;
        List<string> visitedNodes;
        public IslandCount()
        {
            matrix = new string [4, 5] { { "1", "1", "0", "0", "0" }, { "1", "1", "0", "0", "0" }, { "0", "0", "1", "0", "0" }, { "0", "0", "0", "1", "1" } };

        }


        public void IsLandCounter()
        {
            List<string> visitedLocations = new List<string>();
            int islandCounter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var location = i + "," + j;
                    if (!visitedLocations.Contains(location) && matrix[i,j] == "1")
                    {
                        if (countIsland(i,j,matrix, visitedLocations))
                        {
                            islandCounter++;
                        }
                    }
                }
            }
        }

        private bool countIsland(int i, int j, string[,] matrix, List<string> visitedLocations)
        {
            if (i < 0 || j < 0) return false;
            if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1)) return false;
            var location = i + "," + j;
            if (matrix[i, j] == "0" || visitedLocations.Contains(location))
                return false;

            if (matrix[i, j] == "1") visitedLocations.Add(location);

            countIsland(i + 1, j, matrix, visitedLocations);
            countIsland(i - 1, j, matrix, visitedLocations);
            countIsland(i, j + 1, matrix, visitedLocations);
            countIsland(i, j - 1, matrix, visitedLocations);

            return true;
        }



    }
}

