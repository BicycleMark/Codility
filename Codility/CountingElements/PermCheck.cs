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
        // results here: https://app.codility.com/demo/results/trainingUH4N5K-5ZH/
        public int solution(int[] A)
        {
            if (A.Count() != A.Distinct().Count())
                return 0;
           
            if (A.Min() == 1 && A.Max() == A.Length)
                return 1;
            else
                return 0;
            
        }
    }
}