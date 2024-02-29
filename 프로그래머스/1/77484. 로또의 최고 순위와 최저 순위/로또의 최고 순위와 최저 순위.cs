using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int count1 = 0;
        int count2 = 0;

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
                count1++;
            else
            {
                for(int j = 0; j < win_nums.Length; j++)
                {
                    if (lottos[i] == win_nums[j])
                        count1++;
                }}}

        for (int i = 0; i < lottos.Length; i++)
        {
            for (int j = 0; j < win_nums.Length; j++)
            {
                if (lottos[i] == win_nums[j]) 
                    count2++; 
            }}

        answer[0] = result(count1);
        answer[1] = result(count2);

        return answer;
    }

    static int result(int countNumber)
    {
        if (countNumber == 6)
            return 1;
        else if (countNumber == 5)
            return 2;
        else if (countNumber == 4)
            return 3;
        else if (countNumber == 3)
            return 4;
        else if (countNumber == 2)
            return 5;
        else
            return 6;
    }
}