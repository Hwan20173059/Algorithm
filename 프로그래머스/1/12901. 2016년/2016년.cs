public class Solution {
    public string solution(int a, int b) 
    {
        string answer = "";
        int[] month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30 };
        string[] day = { "THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED" };

        for(int i = 0; i < a - 1; i++)
        {
            b += month[i];
        }
        b %= 7;

        return day[b];
    }
}