using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string number = n.ToString();
        
        for (int i = 0; i < number.Length; i++) 
        {
             answer += (int)number[i] - 48;
        }   

            return answer;
    }
}