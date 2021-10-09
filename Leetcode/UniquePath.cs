using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class UniquePath
    {
        public int UniquePaths(int m, int n)
        {
            var value = new Dictionary<string, int>();
            var result = GetValue(m, n, value);
            return result;
        }

        public int GetValue(int m, int n, Dictionary<string, int> value)
        {
            if (value.ContainsKey($"{m},{n}")) return value[$"{m},{n}"];
            if (m < 0 || n < 1) return 0;

            if (m == 1 && n == 1)
            {
                return 1;
            }

            value.Add($"{m},{n}",GetValue(m - 1, n, value) + GetValue(m, n - 1, value));
            return value[$"{m},{n}"];

        }


        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            var dictValue = new Dictionary<string, int>();
            var result = UniquePathValue(3 - 1, 3-1, obstacleGrid, dictValue);
            return result;
        }


        public int UniquePathValue(int m, int n, int[,] obstacleGrid, Dictionary<string, int> dictValue)
        {
            if (dictValue.ContainsKey($"{m},{n}")) return dictValue[$"{m},{n}"];
            if (m < 0 || n < 0) return 0;

            if (m == 1 && n == 1) return 1;

            if (obstacleGrid[m,n] == 1) return 0;


            dictValue.Add($"{m},{n}", UniquePathValue(m - 1, n, obstacleGrid, dictValue) + UniquePathValue(m, n - 1, obstacleGrid, dictValue));
             
            return dictValue[$"{m},{n}"];
        }
    }
}
