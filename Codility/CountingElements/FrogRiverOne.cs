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
        if (A.Length == 1)
        {
            if (A[0] == X)
            {
                return 0;
            }
            else
                return -1;
        }
        bool connected = false;
        var len = A.Length;
        int second = 0;
      
        bool[] visited = new bool[X+1];
            visited[0] = true;
        do
        {
            visited[A[second]] = true;
            connected = visited.Count(v=>v==false) == 0;
            if (!connected && second < len)
                ++second;
        } while (!connected && second < len);

        if (connected)
            return second;
        else
            return -1;
    }
    }
}
