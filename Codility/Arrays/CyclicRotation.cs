using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    public class CyclicRotation
    {
        int[] Shift(int[] array)
        {
            if (array == null || array.Length <= 1)
                return array;
            var nFirst = array[array.Length-1];
            List<int> lst = new List<int>();
            lst.Add(nFirst);
            for (int i= 0; i < array.Length-1; i++)
            {
                lst.Add(array[i]);

            }
            return lst.ToArray();
        }
        //Report: https://app.codility.com/demo/results/trainingA7NCY4-DNY/
        public int[] solution(int[] A, int K)
        {
            int len = A.Length;
            for (int i= 0; i < K; i++)
            {
                A = Shift(A);
            }
            return A;
        }
    }
}
