using System;
public class Solution {
    public long solution(long n)
    {
        long answer = 0;
        double number = Math.Sqrt(n);

        if (number % 1 == 0)
        {
            answer = ((long)number + 1) * ((long)number + 1);
        }
        else
        {
            answer = -1;
        }

        return answer;
    }
}