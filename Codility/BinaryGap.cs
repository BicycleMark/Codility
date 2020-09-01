using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            /*
                [TestCase(9,2, "1001")]
                [TestCase(529,4, "1000010001")]
                [TestCase(20,1, "10100")] 
                [TestCase(15,0,"1111")]
                [TestCase(32,0, "100000")]
             */
            int retVal = 0;
            var binary = Convert.ToString(N, 2);
            var len = binary.Length;
            int currMax = 0;
            if (binary.Count(m => (m == '1')) <= 1)
                return 0;
            
            int i = binary.LastIndexOf('1') ;
            
           

            while ( i > 0)
            {
                if (binary[i] == '0')
                {
                    ++currMax;
                }else
                {
                    if (currMax > retVal)
                       retVal = currMax;
                    currMax = 0;
                }
                --i;     
            }
            if (currMax > retVal )
                retVal = currMax;
            return retVal;       
        }
    }
}
