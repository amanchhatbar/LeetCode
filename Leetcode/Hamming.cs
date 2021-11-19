using System;
namespace Leetcode
{
    public class Hamming
    {
        public int HammingDistance(int x, int y)
        {
            var xBin = Convert.ToString(x, 2);
            var yBin = Convert.ToString(y, 2);


            if(xBin.Length > yBin.Length)
            {
                yBin = yBin.PadLeft(xBin.Length, '0');
            }
            else
            {
                xBin = xBin.PadLeft(yBin.Length, '0');
            }



            var counter = 0;


            for(int i = 0; i < xBin.Length; i++)
            {
                if(xBin[i] != yBin[i])
                {
                    counter++;
                }
            }


            return counter;
        }
    }
}

