using System;
namespace Leetcode
{
    public class StringRotate
    {


        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while(start < end)
            {
                int mid = (start + end) / 2;

                if(nums[mid] == target)
                {
                    return mid;
                }

                if(nums[start] <= nums[mid])
                {
                    if(target >= nums[start] && target <= nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }

                if(nums[end] >= nums[mid])
                {
                    if (target <= nums[end] && target >= nums[mid])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
