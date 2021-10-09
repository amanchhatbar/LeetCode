using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class RecursiveFib
    {
        public int NormalRecursiveFib(int n)
        {

            if(n <= 2)
            {
                return 1;
            }

            return NormalRecursiveFib(n - 1) + NormalRecursiveFib(n - 2);
        }

        public long hasRecursiveFib(int n,Dictionary<int, long> keyValuePairs = null)
        {
            if (keyValuePairs == null) keyValuePairs = new Dictionary<int, long>();

            if (keyValuePairs.ContainsKey(n)) return keyValuePairs[n];
            if (n <= 2)
            {
                return 1;
            }

            keyValuePairs.Add(n,hasRecursiveFib(n - 1, keyValuePairs) + hasRecursiveFib(n - 2, keyValuePairs));

            return keyValuePairs[n];
        }
    }
}
