using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            if (A.Length==1)
            {
                if (A[0] == X)
                {
                    return 0;
                }
                else
                    return -1;
            }
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for (int i = 1; i <= X; i++)
            {
                dict.Add(i, -1);
            }
            int second = 0;

            do
            {
                if (dict.ContainsKey(A[second]))
                    dict[A[second]]++;     
                ++second;
                if (second > A.Length - 1)
                    return -1;
            } while (dict.Values.Count(x => x == -1) > 0);
            return --second;

        }
    }
}
