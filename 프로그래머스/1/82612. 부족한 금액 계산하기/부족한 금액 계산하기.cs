using System;

class Solution
{
    public long solution(long price, long money, int count)
    {
        for (int i = 1; i < count + 1; i++)
        {
            money -= price * i;
        }

        if (money > 0)
            return 0;
        else
            return money * -1;
    }
}