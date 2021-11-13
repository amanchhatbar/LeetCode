using System;
namespace Leetcode
{
    public class DailyTemps
    {
        System.Collections.Stack stack = new System.Collections.Stack();
        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] result = new int[temperatures.Length - 1];

            var totalLength = temperatures.Length - 1;
            for (int i = 0; i < totalLength; i++)
            {
                while (totalLength > 0 && temperatures[1] > temperatures[(int)stack.Peek()])
                {
                    result[(int)stack.Peek()] = i - (int)stack.Peek();
                    stack.Pop();
                }
                stack.Push(i);

            }
            return result;
        }
    }
}

