using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class MicrosoftTest
    {

        public int solution(string S)
        {


            HashSet<String> hashSet = new HashSet<String>();
            S = "cycle";
            for (int i = 0; i < S.Length; ++i)
            {
                bool[] numberSeen = new bool[26];

                String s = "";

                for (int j = i; j < S.Length; ++j)
                {
                    int pos = S[j] - 'a';
                    if (numberSeen[pos] == true)
                        break;

                    numberSeen[pos] = true;
                    s += S[j];
                    hashSet.Add(s);
                }
            }


            for (int i = 0; i < hashSet.Count; i++)
            {

            }

            return hashSet.Count;
        }
        //public int solution(string S)
        //{
        //    S = "abacdec";
        //    int[] lastSeen = new int[26];
        //    Array.Fill(lastSeen, -1);

        //    int[] secLastSeen = new int[26];
        //    Array.Fill(secLastSeen, -1);

        //    int count = 0, res = 0;

        //    var charArray = S.ToCharArray();

        //    for (int i = 0; i < S.Length; i++)
        //    {
        //        int idx = S[i] - 'a';
        //        int p = lastSeen[idx];
        //        int q = secLastSeen[idx];

        //        count += i - p - p + q;
        //        res += count;

        //        secLastSeen[idx] = lastSeen[idx];

        //        lastSeen[idx] = i;
        //    }

        //    return res;
        //}


        //public string[] solution()
        //{
        //    int[] A = new int[] { 4,2,4,5 };



        //    //int [] A = new int[] { 1, 2, 2, 1 };
        //    //if (A.Length % 2 != 0)
        //    //{
        //    //    return false; //to create pairs it has to have even length.
        //    //}

        //    //Dictionary<int, int> pairsValue = new Dictionary<int, int>();
        //    //for (int i = 0; i < A.Length; i++)
        //    //{
        //    //    if (pairsValue.ContainsKey(A[i]))
        //    //    {
        //    //        var count = pairsValue[A[i]];
        //    //        pairsValue[A[i]] = count + 1;
        //    //    }
        //    //    else
        //    //    {
        //    //        pairsValue.Add(A[i], 1);
        //    //    }
        //    //}

        //    //foreach (var items in pairsValue)
        //    //{
        //    //    if (items.Value % 2 != 0)
        //    //    {
        //    //        return false;
        //    //    }
        //    //}


        //    //return true;
        //}
    }
}

