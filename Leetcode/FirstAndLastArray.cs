using System;
namespace Leetcode
{
    public class FirstAndLastArrays
    {
       
        public int[] Recursive(int start, int end, int[] nums, int target)
        {
            var mid = (start + end) / 2;
            if(nums[mid] == target)
            {
                var secondValue = 0;
                if (target == nums[mid + 1])
                {
                    secondValue = mid + 1;
                }
                else
                {
                    secondValue = mid - 1;
                }

                var temp = mid < secondValue ? new int[] { mid, secondValue } : new int[] { secondValue, mid };

                return temp;
            }

            if(start == end)
            {
                return new int[] { };
            }

            if(target < nums[mid])
            {
                return Recursive(start, mid - 1, nums, target);
            }
            else
            {
                return Recursive(mid + 1, end, nums, target);
            }


        }

        public int[] nonRecursion(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1, mid = 0;
            //var mid = (start + end) / 2;

            while(start <= end)
            {
                mid = (start + end) / 2;
                if (target == nums[mid])
                {
                    var secondValue = 0;
                    if (target == nums[mid + 1])
                    {
                        secondValue = mid + 1;
                    }
                    else
                    {
                        secondValue = mid - 1;
                    }

                    var temp = mid < secondValue ? new int[]{ mid, secondValue } : new int[]{ secondValue, mid };

                    return temp;
                }

                if(target <= nums[mid])
                {
                    //start = 0;
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                    //end = end;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
