using System;
namespace Leetcode
{
    public class ShortestPath
    {
        public int MinPathSum(int[,] grid)
        {
            return ShortestPathValue(0, 0, grid);
        }

        public int ShortestPathValue(int m, int n, int[,] grid, int sum = 0)
        {
            if (m > 2 || n > 2) return 0; //TODO
            if (m == 2 && n == 2) return sum; //TODO

            sum += grid[m,n];
            ShortestPathValue(m + 1, n, grid);
            ShortestPathValue(m, n + 1, grid);
            return sum;
        }
    }
}
