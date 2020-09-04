using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Codility
{
    public class MaxCounter
    {
        private int [] setCountersArray(int N, int value)
        {
            List<int> counters = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                counters.Add(value);
            }
            return counters.ToArray();
        }
        public int[] solution(int N, int[] A)
        {
            var countersArray = setCountersArray(N, 0);
            int upper = A.Length;
            for (int i=0; i < upper; i++)
            {               
                if (A[i] == N + 1)
                {
                    countersArray = setCountersArray(N, countersArray.Max());                  
                }else
                {
                    countersArray[A[i] - 1] += 1;
                }
            }
            return countersArray;
        }
    }
}
