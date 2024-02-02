using System;

public class Solution {
    public int solution(string t, string p) {
        string number = "";
        int answer = 0;

        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            for (int j = 0; j < p.Length; j++)
            {
                number += t[i + j];
            }

            if(long.Parse(number) <= long.Parse(p))
            {
                answer++;
            }

            number = "";
        }
        return answer;
    }
}