using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;

        for (int i = left; i <= right; i++)
        {
            if (division(i) % 2 == 0)
                answer += i;
            else
                answer -= i;
        }

        return answer;
    }

    static public int division(int number)
    {
        List<int> list = new List<int>();

        for (int i = 1; i < number + 1; i++)
        {
            if(number % i == 0)
            {
                list.Add(i);
            }
        }

        return list.Count;
    }
}