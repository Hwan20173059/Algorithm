using System;

public class Solution {
    public bool solution(string s) 
    {
        bool answer = false;

        if (s.Length == 4 || s.Length == 6)
        {
            answer = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    answer = false;
                }
            }
        }

        return answer;
    }
}