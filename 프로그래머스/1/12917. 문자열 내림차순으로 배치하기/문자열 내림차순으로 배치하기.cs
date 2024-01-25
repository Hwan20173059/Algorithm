using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> list = s.ToList();

        list.Sort();

        for(int i = list.Count - 1; i >= 0; i--)
        {
            answer += list[i];
        }

        return answer;
    }
}