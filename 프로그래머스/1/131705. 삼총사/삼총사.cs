using System;

public class Solution {
    public int solution(int[] number) 
    {
        int answer = 0;

        for(int i = 0; i < number.Length; i++)
        {
            for (int j = i + 1; j < number.Length; j++) 
            {
                for(int l = j + 1; l < number.Length; l++)
                {
                    if (number[i] + number[j] + number[l] == 0)
                        answer++;
                }
            }
        }

        return answer;
    }
}