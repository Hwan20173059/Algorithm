using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        int n = 0;
        int count = 1;

        List<int> list = new List<int>(10000000);
        Array.Sort(tangerine);

        for (int i = 0; i < tangerine.Length; i++)
        {
            if (n == tangerine[i])
            {
                count++;
            }
            else
            {
                //만약 인덱스의 첫번째라면 그냥 넘긴다.
                if (tangerine[i] == 0) continue;
                list.Add(count);
                count = 1;
            }
            n = tangerine[i];
        }

        list.Add(count);
        list.Sort();
        list.Reverse();

        foreach (int index in list)
        {
            if (k <= 0) break;
            answer++;
            k -= index;
        }
        return answer;
    }
}