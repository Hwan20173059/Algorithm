using System;

public class Solution {
    public int solution(string s) {
        int answer = 0; 
        int sameIdx = 0; 
        int diffIdx = 0; 
        char word = ' '; 
        bool start = true; 
        
        for(int i = 0; i < s.Length; i++)
        {
            if(start == true)
            {
                word = s[i];
                sameIdx++;
                start = false;
            }
            else
            {
                if(s[i] == word)
                {
                    sameIdx++;
                }
                else
                {
                    diffIdx++;
                }
            }
            
            if(sameIdx == diffIdx)
            {
                answer++;
                sameIdx = 0;
                diffIdx = 0;
                start = true;
            }
            if(i == s.Length - 1) { if(start == false) { answer++; } }
        }
        return answer;
    }
}