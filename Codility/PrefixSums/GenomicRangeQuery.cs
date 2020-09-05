using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    public class GenomicRangeQuery
    {
        public int[] solution(String S, int[] P, int[] Q)
        {
            int M = P.Length;
            int[] retVal = new int[M];
            Dictionary<char, int>  sequenceDictionary = new Dictionary<char, int>()
            {
                {'A',1 },{'C',2},{'G',3},{'T',4}
            };
            for (int i = 0; i < M; i++)
            {
                int min = int.MaxValue;
                for (int j=P[i];j<=Q[i];j++)
                { int val = sequenceDictionary[S[j]];
                    if (val < min)
                        min = val;
                    if (min == 1)
                        break;
                }
                retVal[i] = min;
            }
            return retVal;
        }
    }
}
