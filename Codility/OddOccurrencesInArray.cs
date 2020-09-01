using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Codility
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
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
    }
}
