using System;

class Solution
{
    public int solution(int n, int a, int b){
        int answer = 0;

        while (a != b)
        {
            a = (a + 1) / 2;
            Console.Write(a + " ");

            b = (b + 1) / 2;
            Console.Write(b);

            answer++;
            Console.WriteLine(" ");
        }

        return answer;
    }
}