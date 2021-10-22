using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class WordPermutation
    {



        public bool IsPermutationPalindrome(string input)
        {
            if(input.Length == 1)
            {
                return true;
            }

            var dict = new Dictionary<char, int>();

            var charInput = input.ToLower().ToCharArray();
            
            var currentValue = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (charInput[i] != ' ')
                {
                    if (dict.ContainsKey(charInput[i]))
                    {
                        currentValue = dict[charInput[i]];
                        dict[charInput[i]] = currentValue + 1;
                    }
                    else
                    {
                        dict.Add(charInput[i], 1);
                    }
                }
            }

            var valueOne = 0;

            foreach (var item in dict)
            {
                if(item.Value % 2 != 0)
                {
                    valueOne++;                    
                }

                if(valueOne > 1)
                {
                    return false;
                }
            }

            
            return true;

        }
    }
}

