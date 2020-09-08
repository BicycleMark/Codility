using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Codility
{

    public class MaxCounter
    {
        //public static IEnumerable<int> IndexesWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        //{
        //    int index = 0;
        //    foreach (T element in source)
        //    {
        //        if (predicate(element))
        //        {
        //            yield return index;
        //        }
        //        index++;
        //    }
        //}

        // Report https://app.codility.com/demo/results/trainingGENFNJ-ZAD/
        public int[] solutionX(int N, int[] A)
        {
            
            if (N==1)
            {
                return new int[] { A.Length - A.Count(x => x == 2) };
            }
            var countersArray = new int[N];
            int upper = A.Length;
            int curMax = 0;
            for (int i=0; i < upper; i++)
            {               
                if (A[i] == N + 1)
                {
                    countersArray = Enumerable.Repeat<int>(curMax, N).ToArray();
                   
                }else
                {
                    int val = countersArray[A[i] - 1] += 1;
                    if (val > curMax)
                        curMax = val;        
                }
            }
            return countersArray;
        }
        // Report https://app.codility.com/demo/results/training9FJ659-C73/
        public int[] solution(int N, int[] A)
        {

            int[] counter = new int[N];
            int baseMinimum = 0;
            int possibleMinimum = 0;
            int index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                index = A[i] - 1;

                if (index == N)
                {
                    baseMinimum = possibleMinimum;
                }
                else
                {
                    counter[index] = Math.Max(counter[index], baseMinimum);
                    counter[index] += 1;

                    if (possibleMinimum < counter[index])
                    {
                        possibleMinimum = counter[index];
                    }
                }
            }

            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = Math.Max(counter[i], baseMinimum);
            }

            return counter;
        }
    }
}
