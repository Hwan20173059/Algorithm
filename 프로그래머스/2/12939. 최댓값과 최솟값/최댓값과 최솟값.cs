using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s)
    {
        List<int> ints = new List<int>();
        string[] strings = s.Split(' ');
        string answer = "";

        for(int i = 0; i < strings.Length; i++)
        {
            ints.Add(int.Parse(strings[i]));
        }

        answer += ints.Min();
        answer += " ";
        answer += ints.Max();

        return answer;
    }
}