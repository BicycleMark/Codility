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

        public int solution(int[] A)
        {
            if (A.Count(x=>x>0) == 0)
            {
                return 1;
            }else
            {
                var positiveSubset = A.Where(x => x >= 1).Distinct();
                if (positiveSubset.Min() > 1)
                    return 1;
                if (isContiguous(positiveSubset.ToArray()))
                    return positiveSubset.Max() + 1;
                else
                {
                    positiveSubset = positiveSubset.OrderBy(x => x);
                    var fullArray = Enumerable.Range(1, A.Max()).ToArray();
                    return fullArray.Except(positiveSubset).OrderBy(x => x).First();
                }   
            }
        }
    }
}
