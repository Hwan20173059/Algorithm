using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(string today, string[] terms, string[] privacies)
    {
        List<int> answer = new List<int>();
        DateTime todayDt = DateTime.Parse(today);

        Dictionary<string, string> temrsDic = new Dictionary<string, string>();

        for (int i = 0; i < terms.Length; i++)
        {
            string[] ss = terms[i].Split(" ");
            temrsDic.Add(ss[0], ss[1]);
        }

        for (int i = 0; i < privacies.Length; i++)
        {
            string[] ss = privacies[i].Split(" ");

            if (temrsDic.TryGetValue(ss[1], out string value))
            {
                DateTime privacie = DateTime.Parse(ss[0]).AddMonths(int.Parse(value));

                if (todayDt.CompareTo(privacie) != -1)
                {
                    answer.Add(i + 1);
                }
            }
        }

        answer.Sort();
        return answer.ToArray();
    }
}