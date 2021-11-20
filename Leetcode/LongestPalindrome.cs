using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class LongestPalindrome
    {
        public int LongestValuePalindrome(string s)
        {

            var dict = new Dictionary<string, int>();

            var inputChar = s.ToCharArray();

            int temp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var inputString = inputChar[i].ToString();
                if (dict.ContainsKey(inputString))
                {
                    temp = dict[inputString];
                    dict[inputString] = temp + 1;
                }
                else
                {
                    dict.Add(inputString, 1);
                }
            }

            temp = 0;

            int evenCount = 0;
            foreach (var item in dict)
            {
                if((item.Value) %2 == 0)
                {
                    evenCount += item.Value;
                }
                else
                {
                    if(temp < item.Value)
                    {
                        temp = item.Value;
                    }
                }
            }


            return evenCount + temp;
        }
    }
}

