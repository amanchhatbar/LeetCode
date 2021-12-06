using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class DegreeOfArray
    {
        public int FindShortestSubArray()
        {
            var counter = 0;
           int[] nums = new int[] {1, 2, 2, 3, 1};
            var dictCounter = new Dictionary<int, int>();
            var temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                temp = 0;
                if (dictCounter.ContainsKey(nums[i]))
                {
                    temp = dictCounter[nums[i]];
                    temp += 1;
                    dictCounter[nums[i]] = temp;
                   
                }
                else
                {
                    dictCounter.Add(nums[i], 1);
                   
                }
            }

            return counter;
        }
    }
}

