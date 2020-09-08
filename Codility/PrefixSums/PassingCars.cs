using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Codility
{
    public class PassingCars
    {

        // Finished report https://app.codility.com/demo/results/training8P7X25-QAX/
        //public int solution(int[] A)
        //{
        //    int retVal = 0;
        //    var len = A.Length;

        //    for (int i = 0; i < len; i++)
        //    {
        //        if (A[i] == 0)
        //        {
        //            for (int j = i + 1; j < len; j++)
        //            {
        //                retVal += A[j];

        //            }
        //            if (retVal > 1000000000)
        //                return -1;
        //        }
        //    }

        //    return retVal;

        //}

        //public int solution(int[] A)
        //{
        //    int retVal = 0;
        //    var len = A.Length;

        //    for (int i = 0; i < len; i++)
        //    {
        //        if (A[i] == 0)
        //        {
        //            retVal += A.Where((n, index) => (index >= i + 1)).ToList().Sum();
        //        }
        //        if (retVal > 1000000000)
        //            return -1;
        //    }
        //    return retVal;
        //}
        //public int solution(int[] A)
        //{
        //    int retVal = 0;
        //    var len = A.Length;
        //    int lastSumIndex = len - 1;
        //    int runningSum = 0;
        //    for (int i = len - 1; i >= 0; i--)
        //    {
        //        if (A[i] == 0)
        //        {
        //            var sum = A.Where((n, index) => (index <= lastSumIndex && index >= i)).ToList().Sum();
        //            retVal += sum;
        //            lastSumIndex = i;
        //        }
        //        if (retVal > 1000000000)
        //            return -1;
        //    }
        //    return retVal;

        //}
        // report here: https://app.codility.com/demo/results/training4NFZNB-YQQ/
        public int solution(int[] A)
        {

            int l = A.Length;
            int countZero = 0;
            int countPairs = 0;
            int exceed = 1000000000;


            for (int i = 0; i < l; i++)
            {
                if (A[i] == 1)
                    countPairs += countZero;
                else
                    countZero++;
                if (countPairs > exceed || countPairs < 0) return -1;
            }
            return countPairs;
        }
    }
}

