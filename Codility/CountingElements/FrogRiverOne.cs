using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class FrogRiverOne
    {

        // The report https://app.codility.com/demo/results/training5WWA2S-K3N/
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
      
            bool[] visited = new bool[X];

            int ptVisited = 0;
            do
            {   
                if (!visited[A[second]-1])
                {
                    visited[A[second]-1] = true;
                    ++ptVisited;
                    connected = ptVisited == X;
                }
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
