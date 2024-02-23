using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers){
        List<int> answer = new List<int>();

        int[] answer1 = { 1, 2, 3, 4, 5 };
        int[] answer2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] answer3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        int[] count = { 0, 0, 0 };

        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == answer1[i % 5])
                count[0]++;

            if (answers[i] == answer2[i % 8])
                count[1]++;

            if (answers[i] == answer3[i % 10])
                count[2]++;
        }
        
        for(int i = 0; i < count.Length; i++)
        {
            if (count[i] == count.Max())
                answer.Add(i + 1);
        }
        
        return answer.ToArray();
    }
}