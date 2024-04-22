using System;
using System.Collections.Generic;

public class Solution {
    public List<int> numList = new List<int>();

    public int solution(int[] numbers, int target)
    {
        int answer = 0;

        Calculate(-1, 0, numbers);

        int cnt = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            cnt *= 2;
        }

        while (true)
        {
            if (numList.Count == cnt)
            {
                break;
            }
        }

        for (int j = 0; j < numList.Count; j++)
        {
            if (numList[j] == target) answer++;
        }

        return answer;
    }

    public void Calculate(int repeatCount, int num, int[] numbers)
    {
        repeatCount++;

        if (repeatCount == numbers.Length)
        {
            numList.Add(num);
            return;
        }

        Calculate(repeatCount, num + PlusMinus(numbers[repeatCount], true), numbers);
        Calculate(repeatCount, num + PlusMinus(numbers[repeatCount], false), numbers);
    }

    public int PlusMinus(int num, bool is_true)
    {
        if (is_true)
            return num;
        else
            return (-1) * num;
    }
}