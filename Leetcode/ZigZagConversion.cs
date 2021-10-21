using System;
namespace Leetcode
{
    public class ZigZagConversion
    {
        public ZigZagConversion()
        {
        }

        public string Convert(string s, int numRows)
        {

            var stringChar = s.ToCharArray();
            int j = 0;
            for (int i = 0; i < 100; i++) //Column TODO: MaxLimit
            {
                if (i / (numRows - 1) == 0)
                {
                    for (j = 0; j < numRows; j++) //Row
                    {

                    }
                }
                else
                {
                    for (; j < numRows; j++) //Row
                    {

                    }
                    j--;
                }
                
            }



            return s;
        }
    }
}

