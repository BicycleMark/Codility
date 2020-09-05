using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            List<int> lst = new List<int>();
            if (A == null || A.Length == 0)
                return 0;
            if (A.Length == 1)
                return 1;
            lst.Add(A[0]);
            int len = A.Length;
            for (int i = 1;i < len; i++ )
            {
                if (!lst.Contains(A[i]))
                    lst.Add(A[i]);

            }
            return lst.Count;
        }
    }
}
