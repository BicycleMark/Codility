using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Codility
{
    public class PermMissingElem
    {
        //Report: https://app.codility.com/demo/results/trainingWUWJEA-4ME/
        public int solution(int[] A)
        {
            if (A == null || A.Length == 0 )
                return 1;
            if (A.Length == 1)
            {
                if (A[0] == 1)
                    return 2;
                else
                    return 1;
            }
        
            A = A.OrderBy(x => x).ToArray();
            int ret = 0;
            var fullArray = Enumerable.Range(1, A.Max()).ToArray();
            if (fullArray.Length <= A.Length)
            {
                if (fullArray[0] == 1)
                    ret = fullArray[fullArray.Length - 1] + 1;
                else
                    ret = 1;
            }else
                ret = fullArray.Except(A).First();
            return ret;
        }
    }
}
