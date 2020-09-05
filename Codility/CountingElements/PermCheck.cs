using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace Codility
{
    class PermCheck
    {
        bool isContiguous(int[] arr)
        {
            int cnt = arr.Count();
            var max = arr.Max();
            var min = arr.Min();
            if (max - min == cnt - 1)
                return true;
            else
                return false; ;
        }
        public int solution(int[] A)
        {
            if (A.Count() != A.Distinct().Count())
                return 0;
            if (A.Count() == 1)
            {
                return 1;
            }
            A = A.OrderBy(x => x).ToArray();
            var fullArray = Enumerable.Range(A.Min(), A.Max()).ToArray();
            if (fullArray.Except(A).Count() == 0)
                return 1;
            else
                return 0;
        }
    }
}