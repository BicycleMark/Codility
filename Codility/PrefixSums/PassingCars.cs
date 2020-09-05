using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            int retVal = 0;
            var len = A.Length;
            
            for (int i = 0; i < len; i++)
            {
                if (A[i] == 0)
                {
                    for (int j = i+1; j < len; j++)
                    {
                        retVal += A[j];

                    }
                }
            }

            return retVal;

        }
    }
}
