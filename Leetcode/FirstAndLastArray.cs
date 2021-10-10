using System;
namespace Leetcode
{
    public class FirstAndLastArray
    {
        public int[] SearchRange(int[] nums, int target)
        {

        }


        public void nonRecursion(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1, mid = 0;
            //var mid = (start + end) / 2;

            while(start <= end)
            {
                mid = (start + end) / 2;
                if (target == nums[mid])
                {
                    //TODO: Check the neighbouring elements 
                }

                if(target <= nums[mid])
                {
                    start = 0;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                    end = end;
                }
            }
        }
    }
}
