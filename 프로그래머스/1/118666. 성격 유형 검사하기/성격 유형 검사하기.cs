using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        int RT = 0;
        int CF = 0;
        int JM = 0;
        int AN = 0;

        for (int i = 0; i < survey.Length; i++)
        {
            if (survey[i][0] == 'R')
                RT += 4 - choices[i];
            else if (survey[i][0] == 'T')
                RT += choices[i] - 4;
            else if (survey[i][0] == 'C')
                CF += 4 - choices[i];
            else if (survey[i][0] == 'F')
                CF += choices[i] - 4;
            else if (survey[i][0] == 'J')
                JM += 4 - choices[i];
            else if (survey[i][0] == 'M')
                JM += choices[i] - 4;
            else if (survey[i][0] == 'A')
                AN += 4 - choices[i];
            else if (survey[i][0] == 'N')
                AN += choices[i] - 4;
        }

        if (RT >= 0)
            answer += "R";
        else
            answer += "T";

        if (CF >= 0)
            answer += "C";
        else
            answer += "F";

        if (JM >= 0)
            answer += "J";
        else
            answer += "M";

        if (AN >= 0)
            answer += "A";
        else
            answer += "N";


        return answer;
    }
}