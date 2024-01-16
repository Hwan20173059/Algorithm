using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;

        string a = n.ToString();

        long[] number = new long[a.Length];

        for(int i = 0; i < number.Length; i++)
        {
            number[i] = (long)a[i]-48;
        }

        Array.Sort(number);
        long b = 1;

        for (long i = 0; i < number.Length; i++)
        {
           answer += (number[i] * b);
            b *= 10;
        }

        return answer;
    }
}