public class Solution {
    public string solution(string[] seoul) {
        int number = 0;

        for(int i = 0; i < seoul.Length; i++)
        {
            if (seoul[i] == "Kim")
            {
               number = i;
           }
        }

        string answer = "김서방은 " + number +"에 있다";
        return answer;
    }
}