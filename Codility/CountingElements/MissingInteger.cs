using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Codility
{
    public class MissingInteger
    {
        bool isContiguous(int []arr)
        {
            int cnt = arr.Count();
            var max = arr.Max();
            var min = arr.Min();
            if (max - min == cnt - 1)
                return true;
            else
                return false; ;
        }

        //Test report here: https://app.codility.com/demo/results/trainingF9HN7G-D8R/
        public int solution(int[] A)
        {
            A = A.Where(x => x > 0).OrderBy(x => x).Distinct().ToArray();
            if (A.Length==0 || A.Count(x => x > 0) == 0 || !A.Contains(1))
            {
                return 1;
            }else
            {
                int len = A.Length;
                if (isContiguous(A))
                    return A[len-1]+1;
                else
                {
                    var max = A.Max();
                    var positiveSubset = A.Where(x => x >= 1).ToArray();
                    for (int i = 0; i < positiveSubset.Length; i++)
                    {
                        if (i + 1 != positiveSubset[i])
                            return i + 1;
                    }
                }   
            }
            return -1;
        }
    }
}
