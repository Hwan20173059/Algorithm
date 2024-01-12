public class Solution {
    public int[] solution(long n) {
        string number = n.ToString();
        int[] answer = new int[number.Length];
        int j = 0;

        for (int i = number.Length-1; i >= 0; i--)
        {
          answer[j] = (int)number[i] - 48;
            j++;
        }

        return answer;
    }
}