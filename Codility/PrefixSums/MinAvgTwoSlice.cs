using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    public class MinAvgTwoSlice
    {
        /// <summary>
        /// given a non-empty array A consisting of N integers, returns the starting position of the slice with  the minimal average. If there is more than one slice with a minimal average, you should return the   smallest starting position of such a slice.

        //        For example, given array A such that:

        //    A[0] = 4
        //    A[1] = 2
        //    A[2] = 2
        //    A[3] = 5
        //    A[4] = 1
        //    A[5] = 5
        //    A[6] = 8
        //the function should return 1, as explained above.

        //Write an efficient algorithm for the following assumptions:

        //N is an integer within the range[2..100, 000];
        //        each element of array A is an integer within the range[−10, 000..10, 000].
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
        {
          
           
            int sliceThickness = 3 ;
            int len = A.Length;
            if (len % 2 == 0)
                sliceThickness = 3;
            int i = sliceThickness-1;
            var minAvg = double.MaxValue;
            var P = int.MaxValue;
            while(i < len)
            {
                int sum = 0;
                for (int j=sliceThickness; j>=0; j--)
                {
                    sum += A[i + j];
                }
                var avg = sum / sliceThickness;
                if (avg < minAvg)
                {
                    minAvg = avg;
                    P = i;

                }
                i += sliceThickness;
            }
            return P;  
        }
       

        
    }
}
