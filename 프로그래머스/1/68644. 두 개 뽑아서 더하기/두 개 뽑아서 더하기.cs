using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) 
    {
        List<int> list = new List<int>();

        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                list.Add(numbers[i] + numbers[j]);
            }
        }

        list.Sort();

        return list.Distinct().ToArray();
    }
}