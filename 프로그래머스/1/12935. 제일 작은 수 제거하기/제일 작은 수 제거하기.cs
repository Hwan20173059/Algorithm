using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) 
    {
        List<int> list = new List<int>(arr);
        int min;

        if (list.Count > 1)
        {
            min = list.Min();
            list.Remove(min);
        }
       else
           list[0] = -1;

       return list.ToArray();
    }
}