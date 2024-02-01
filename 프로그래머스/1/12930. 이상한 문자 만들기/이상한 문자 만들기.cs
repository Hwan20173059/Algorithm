using System;

public class Solution {
    public string solution(string s) 
    {
        string[] _string = s.Split(' ');
        string answer = "";

        for(int i = 0; i < _string.Length; i++)
        {
            for (int j = 0; j < _string[i].Length; j++)
            {
                if(j == 0 || j % 2 == 0)
                {
                    answer += Char.ToUpper(_string[i][j]);
                }
                else
                {                 
                    answer += Char.ToLower(_string[i][j]);
                }
            }
            if(i != _string.Length -1)
                answer += " ";
        }

        return answer;
    }
}