using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class SchneiderProblemOne //Solution
{
    public int solution(string s)
    {
        int retVal = -1;
        if (s.Length < 2)
        {
            return -1;
        }

        int len = s.Length;
        string diagram;
        int maxDistance = -1;
        
        for (int i = 1; i < len; i++)
        {
            diagram = s.Substring(i - 1, 2);
            retVal = s.LastIndexOf(diagram);
            if ( retVal != i - 1)
            {
                maxDistance = Math.Max(retVal - i + 1, maxDistance);
            }   
        }
        return maxDistance;  
    }
}
