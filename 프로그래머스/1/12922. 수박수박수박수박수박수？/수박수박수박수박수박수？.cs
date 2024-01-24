public class Solution {
    public string solution(int n) {
        string answer = "";

        if(n%2 == 0)
        {
            for (int i = 0; i < n / 2; i++)
                answer += "수박";
        }
        else
        {
            for (int i = 0; i <= n / 2 - 1; i++)
                answer += "수박";
            answer += "수";
        }

        return answer;
    }
}