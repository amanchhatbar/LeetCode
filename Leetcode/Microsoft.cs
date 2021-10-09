using System;
namespace Leetcode
{
    public class Microsoft
    {
        public Microsoft()
        {
        }


        public string GetColumnValue(int input)
        {
            string[] alphabet = new string[]
            {
                "0","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O"
                ,"P","Q","R","S","T","U","V","W","X","Y","Z"
            };

            var temp = input;
            var remainder = string.Empty;
            while(temp > 26)
            {
                remainder += $"{temp % 26},";
                temp = temp / 26;                
            }

            var intArray = remainder.Split(',');
            var result = alphabet[temp];
            for (int i = 0; i < intArray.Length -1; i++)
            {
                result = result + alphabet[Convert.ToInt32(intArray[i])];
            }

            return result;
        }
    }
}
