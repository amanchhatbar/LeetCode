using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class CanSum
    {
        public bool CanSumMethod(int target, int[] numbers, Dictionary<int, bool> keyValuePairs = null)
        {
            if (keyValuePairs == null) keyValuePairs = new Dictionary<int, bool>();
            if (keyValuePairs.ContainsKey(target)) return keyValuePairs[target];
            if (target == 0) return true;
            if (target < 0) return false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(CanSumMethod(target - numbers[i], numbers, keyValuePairs))
                {
                    keyValuePairs.Add(target, true);
                    return keyValuePairs[target];
                }                
            }
            keyValuePairs.Add(target, false);
            return keyValuePairs[target];
            
        }
           
    }
}
