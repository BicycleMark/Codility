using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;

namespace Codility
{
    public class MaxProductOfThree
    {


        // Passing url = https://app.codility.com/demo/results/trainingA9MA6Q-EM2/
        public int solution(int[] A)
        {
            A = A.OrderBy(x => x).ToArray();
            int F = 0;
            int L = A.Length - 1;
            int s1 = A[F] * A[F + 1] * A[F + 2];
            int s2 = A[L] * A[L - 1] * A[F];
            int s3 = A[F] * A[F + 1] * A[L];
            int s4 = A[L] * A[L - 1] * A[L - 2];
            return Math.Max(Math.Max(s1, s2), Math.Max(s3, s4));
        }
    }
    public class Test
    {
       [TestCase(-120,-5, -6, -4, -7, -10)]
       [TestCase(125, -5, 5, -5, 4)]
        
        [TestCase(-80,-10, -2, -4)]
        [TestCase(60,
                   -3,
                   1,
                   2,
                   -2,
                   5,
                   6)]
        [TestCase(125,
                  -5, 5, -5, 4)]
        
        public void TestMaxProductOfThree(int expected, params int[]A)
        {
            var prob = new MaxProductOfThree();
            Assert.AreEqual(expected,prob.solution( A));

        }


    }
}
