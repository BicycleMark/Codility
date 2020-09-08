using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Codility
{
    public class OddOccurrencesInArray
    {
        //Report: https://app.codility.com/demo/results/trainingQF5QUB-SGN/
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
