using System;

public class Solution {
    public int[] solution(string s) 
    {
        int[] answer = new int[s.Length];

        for(int i = 0; i < s.Length; i++)
        {
            answer[i] = -1;
        }

        for (int i = 0; i < s.Length; i++) 
        {
            char cha = s[i];

            for(int j = 0; j < i; j++)
            {
                if (s[j] == cha)
                {
                    if (i != j)
                        answer[i] = i - j;
                }
            }
        }
        return answer;
    }
}