using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class GridTraveller
    {

        public int TravelGridRecursively(int m, int n)
        {
            if (m <= 0 || n <= 0)
            {
                return 0;
            }

            if (m == 1 && n == 1)
            {
                return 1;
            }

            return TravelGridRecursively(m - 1, n) + TravelGridRecursively(m, n - 1);
        }

        public long TravelGridRecursivelyMemoization(int m, int n, Dictionary<string, long> keyValuePairs = null)
        {
            if (keyValuePairs == null) keyValuePairs = new Dictionary<string, long>();
            if (keyValuePairs.ContainsKey($"{m},{n}")) return keyValuePairs[$"{m},{n}"];
            if (m <= 0 || n <= 0)
            {
                return 0;
            }

            if (m == 1 && n == 1)
            {
                return 1;
            }

            keyValuePairs.Add($"{m},{n}", TravelGridRecursivelyMemoization(m - 1, n, keyValuePairs) + TravelGridRecursivelyMemoization(m, n - 1, keyValuePairs));
            return keyValuePairs[$"{m},{n}"];
        }
    }
}
