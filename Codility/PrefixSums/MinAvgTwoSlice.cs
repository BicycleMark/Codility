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
            Dictionary<(int P, int Q), double> avgDictionary = new Dictionary<(int P, int Q), double>();
            int N = A.Length;
            List<(int p, int q)> lstMins = new List<(int p, int q)>(); 
            
            double minAvg = double.MaxValue;
            int minP = int.MaxValue;
            int minQ = int.MaxValue;
            for (int p = 0; p < N; p++)
            {
                double avg = double.MaxValue ;
                int nPass = 1;
                int sum = A[p];
                for (int q = p + 1; q < N; q++)
                {
                    
                    if (avgDictionary.ContainsKey((p, q)))
                    {
                        avg = avgDictionary[(p, q)];
                        break;

                    }else
                    {
                        sum += A[q];
                        avg = sum / ++nPass;
                        avgDictionary.Add((p, q), avg);
                    }
                    if (avg < minAvg)
                    {
                        minAvg = avg;
                        minP = p;
                        minQ = q;
                        
                        lstMins.Add((minP, minQ));

                    }
                    ++nPass;

                }
                       
        }
        return lstMins[0].p;

        }
    }
}
