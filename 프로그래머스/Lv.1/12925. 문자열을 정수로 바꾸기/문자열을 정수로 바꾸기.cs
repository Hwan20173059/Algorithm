public class Solution {
    public int solution(string s) {
        char[] number = new char[s.Length - 1];
int answer = 0;

if (s[0] == '+')
{
    for (int i = 1; i < s.Length; i++)
    {
        number[i - 1] = s[i];
    }

    answer = int.Parse(number);
}
else if (s[0] == '-') 
{
    for (int i = 1; i < s.Length; i++)
    {
        number[i - 1] = s[i];
    }

    answer = int.Parse(number) * -1;
}
else
{
    answer = int.Parse(s);
}

return answer;
    }
}