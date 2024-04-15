using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[progresses.Length];
            
        int length = progresses.Length;

        int[] remainProgressPerDay = new int[progresses.Length];

        for (int i = 0; i < length; i++)
        {
            remainProgressPerDay[i] = (int)Math.Ceiling(((100 - progresses[i]) / (double)speeds[i]));
        }

        int answerCnt = 0;

        int releaseCount = 1;
        int tmpbiggestvalue = remainProgressPerDay[0];

        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
                answer[answerCnt++] = releaseCount;
            else if (tmpbiggestvalue >= remainProgressPerDay[i + 1])
                releaseCount++;
            else
            {
                answer[answerCnt++] = releaseCount;
                tmpbiggestvalue = remainProgressPerDay[i + 1];
                releaseCount = 1;
            }
        }

        return answer.Where(x => x != 0).ToArray();
    }
}