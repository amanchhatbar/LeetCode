using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    public class CharsByFrequency
    {
        public string FrequencySort(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }
            var result = string.Empty;
            var dictValue = new Dictionary<char, int>();
            var inputInChar = s.ToCharArray();
            int temp = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (dictValue.ContainsKey(inputInChar[i]))
                {
                    temp = dictValue[inputInChar[i]];

                    dictValue[inputInChar[i]] = temp + 1;
                }
                else
                {
                    dictValue.Add(inputInChar[i], 1);
                }
            }

            var resultOrdered = dictValue.OrderByDescending(x => x.Value);


            foreach (var item in resultOrdered)
            {
                var tempValue = item.Value;

                while(tempValue > 0)
                {
                    result += item.Key;

                    tempValue--;
                }
            }

            return result;

        }
    }
}

