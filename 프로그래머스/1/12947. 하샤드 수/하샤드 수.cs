public class Solution {
    public bool solution(int x) {
        bool answer = true;

        string number = x.ToString();
        int sum = 0;

        for (int i = 0; i < number.Length; i++) 
        {
            sum += (int)number[i]-48;
        }

        if (x % sum == 0)
            answer = true;
        else
            answer = false;

        return answer;
    }
}