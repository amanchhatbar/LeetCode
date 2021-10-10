using System;
using System.Collections.Generic;
namespace Leetcode
{
    public class HowSum
    {


        public List<int> HowSumRecursive(int target, int[] numbers, List<int> resultList)
        {
            if (resultList == null)
            {
                resultList = new List<int>();
            }
            if (target < 0) return null;
            if (target == 0) return new List<int>() ;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("i " + i);
                Console.WriteLine("Target " + target);
                var result = HowSumRecursive(target - numbers[i], numbers, resultList);
                Console.WriteLine(result);
                Console.WriteLine("Target " + target);
                if (result != null)
                {
                    resultList.Add(target);
                    Console.WriteLine(target);
                }
            }

            return null;
        }

    }


}
