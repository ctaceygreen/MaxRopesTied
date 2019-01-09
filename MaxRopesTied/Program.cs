using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int K, int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        // Think we can just be greedy, and take the first next rope and tie until we are >= K. Then start a new rope tieing
        
        int numberOfRopesOverK = 0;
        long currentRopeLength = 0;
        for(int i = 0; i < A.Length; i++)
        {
            long newLength = A[i] + currentRopeLength;
            if (newLength >= K)
            {
                numberOfRopesOverK++;
                currentRopeLength = 0;
            }
            else
            {
                currentRopeLength = newLength;
            }
        }
        return numberOfRopesOverK;
    }
}