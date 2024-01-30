public class Solution {
    public int[] solution(int n, int m)
    {
        int[] answer = { 0, 0 };

        int min = 0;
        int max = 0;
        int a = 0;
        
        for (int i = n * m; i >= 1; i--)
        {
            if (i % n == 0 && i % m == 0)
                min = i;
        }

        while (m > 0)
        {
            a = n % m;
            n = m;
            m = a;
        }
        max = n;

        answer[0] = max;
        answer[1] = min;

        return answer;
    }
}