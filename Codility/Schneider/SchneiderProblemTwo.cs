using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class SchneiderProblemTwo //Solution
{

    public int solutionWorks(int[] A)
    {
        const int overrun = 1000000000;
        int len = A.Length;
        int total = 0;
        for (int i = 0; i < len; i++)
        {
            var cnt = A.Where((r, index) => index > i && r == A[i]).Count();
            total += cnt;
            if (total >= overrun)
                return overrun;
        }
        return total;

    }
    public int solution(int[] A)
    {
        const int overrun = 1000000000;
        int len = A.Length;
        int total = 0;
        for (int i = 0; i < len; i++)
        {
            var cnt = A.Where((r, index) => index > i && r == A[i]).Count();
            total += cnt;
            if (total >= overrun)
                return overrun;
        }
        return total;

    }
}

