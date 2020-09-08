using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class BinaryGap
    {
        //Report: https://app.codility.com/c/close/trainingKYR5CD-F3U/?final_task_completed=1
        public int solution(int N)
        {
           
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
