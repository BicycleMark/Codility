using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class TapeEqiuilibrium
    {
        //Report: https://app.codility.com/demo/results/trainingJDH2JF-UDT/
        public int solution(int[] A)
        {
          
            long minDiff = long.MaxValue;
            long remainingSum = A.Sum()-A[0];
            long runningSum = A[0];
            
            for  (int P = 1; P <= A.Length-1; P++)
            {
               
                var dif =Math.Abs( runningSum - remainingSum);
                if (dif < minDiff )
                {
                    minDiff = dif;
                }
                int n = A[P];
                remainingSum -= n;
                runningSum += n;
            }
            return (int)minDiff; ;
        }
    }
}
