using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility
{
    public class CountDiv
    {
        /// <summary>
        /// that, given three integers A, B and K, returns the number of integers within the range [A..B] that are divisible by K, i.e.:

        //{ i : A ≤ i ≤ B, i mod K = 0 }
        
        //    For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range[6..11], namely 6, 8 and   10.
        
        //Write an efficient algorithm for the following assumptions:
        
        //A and B are integers within the range[0..2, 000, 000, 000];
        //    K is an integer within the range[1..2, 000, 000, 000];
        //A ≤ B.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int solution(int A, int B, int K)
        {
            int retVal = 0;
            for (int i=A; i <= B; i++ )
            {
                if (i % K == 0)
                {
                    ++retVal;
                    i += K-1;
                }
                
            }
            return retVal;
        }
    }
}
