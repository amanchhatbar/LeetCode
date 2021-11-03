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
            matrix = new string[6, 5] { { "W","L","W","W","W"}, { "W","L","W","W","W"}, { "W","W","W","L","W"}, { "W","W","L","L","W"}, { "L","W","W","L","L"}, { "L","L","W","W","W"}};
        }


        public void countIslands()
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (isIsland(matrix, i,j))
                    {
                        count++;
                    }
                }
            }
        }

        public bool isIsland(string[,] matrix, int row, int col)
        {


            var rowBound = row >= 0 && row >= matrix.GetLength(0);
            var colBound = col >= 0 && col >= matrix.GetLength(1);

            if (!rowBound || !colBound) return false;

            if (matrix[row,col] == "W") return false;

            var post = row + "," + col;

            if (visitedNodes.Contains(post)) return false;
            visitedNodes.Add(post);

            isIsland(matrix, row - 1, col);
            isIsland(matrix, row + 1, col);
            isIsland(matrix, row, col - 1);
            isIsland(matrix, row, col + 1);

            return true;
        }
    }
}

