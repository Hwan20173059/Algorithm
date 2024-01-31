using System;

public class Solution {
    public int solution(int n) 
    {
        int answer = 0;
        string three = "";

        while (n > 0)
        {
            answer = n % 3;
            three += answer.ToString();
            n /= 3;
        }

        answer = 0;

        for (int i = three.Length - 1; i >= 0; i--)
        {
            char c = three[i];
            answer += ((int)c - 48) * ((int)Math.Pow(3, three.Length - i - 1));
        }

        return answer;
    }
}