using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility
{
    public class Distinct
    {
        // Graded Solution https://app.codility.com/demo/results/training2VKJMY-JT6/
        public int solution(int[] A)
        {
            List<int> lst = new List<int>();
            if (A == null || A.Length == 0)
                return 0;
          
            int len = A.Length;
          
            return A.ToList().Distinct().Count(); ;
           
        }
    }
}
