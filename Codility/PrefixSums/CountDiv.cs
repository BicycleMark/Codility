using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility
{
    public class CountDiv
    {
        // Graded Solution At https://app.codility.com/demo/results/trainingDBQD2C-JZ3/
        public int solution(int A, int B, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            while (A % K != 0)
            {
                ++A;
            }
            while (B % K != 0)
            {
                --B;
            }
            return (B - A) / K + 1;
        }
    }
}
