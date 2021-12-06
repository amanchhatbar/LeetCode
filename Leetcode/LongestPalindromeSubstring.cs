using System;
namespace Leetcode
{
    public class LongestPalindromeSubstring
    {
        public string LongestPalindrome(string s)
        {

            Console.WriteLine(IsPalindrome("ada"));
            Console.WriteLine(IsPalindrome("adda"));
            Console.WriteLine(IsPalindrome("addda"));
            Console.WriteLine(IsPalindrome("adaa"));

            return "sdfsfS";
        }

        private bool IsPalindrome(string input)
        {
            var inputToChar = input.ToCharArray();
            var lastIndex = input.Length-1;
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[lastIndex])
                {
                    return false;
                }

                lastIndex--;
            }

            return true;

        }
    }
}

