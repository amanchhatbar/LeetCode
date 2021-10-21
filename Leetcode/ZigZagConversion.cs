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
                for (; j < numRows; j++) //Row
                {
                    if(i / (numRows - 1) == 0)
                    {
                        j = 1;
                        break;
                       
                    }
                }
                j--;
            }



            return s;
        }
    }
}

