using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;

        for(int i = 1; i <=n; i++)
        {
            if(lost.Contains(i))
            {
                if(reserve.Contains(i - 1) && !lost.Contains(i - 1))
                {
                    reserve = reserve.Where(value => value != i - 1).ToArray();
                    answer++;
                } 
                else if (reserve.Contains(i))
                {
                    reserve = reserve.Where(value => value != i).ToArray();    
                    answer++;
                }
                else if (reserve.Contains(i + 1) && !lost.Contains(i + 1))
                {
                    reserve = reserve.Where(value => value != i + 1).ToArray();
                    answer++;
                }
            }
            else
            {
                answer++;    
            }
        }

        return answer;
    }
}