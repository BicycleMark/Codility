using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Codility
{
    public class OddOccurrencesInArray
    {
        public int solutioXn(int[] A)
        {
            int foundValue = -1;
            while (foundValue < 0)
            {
                for (int i = 0; i < A.Length && foundValue < 0; i++)
                {
                    var cnt = A.Count(m => m == A[i]);
                    if (cnt % 2 != 0)
                    {
                        foundValue = A[i];
                        break;
                    }
                       
                }
            }
            return foundValue;
        }

        public int solution(int[] A)
        {
            int keyToReturn = -1;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (dict.ContainsKey(A[i]))
                {
                    dict[A[i]]++;
                }else
                {
                    dict.Add(A[i], 1);
                }
            }
            var isOdd = false;
            
            while (!isOdd)
            {              
                foreach (int key in dict.Keys)
                {

                    keyToReturn = key;
                    isOdd = dict[key] % 2 != 0;
                    if (isOdd)
                    {
                        return key;
                    }
                }
            }
            return keyToReturn;
        }
    }
}
