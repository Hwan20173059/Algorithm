using System;

class Solution
{
    public int solution(int[] nums){
        int answer = 0;

        for(int i = 0; i < nums.Length - 2; i++){
            for(int j = i + 1; j < nums.Length - 1; j++){
                for(int k = j + 1; k < nums.Length; k++){
                    int number = nums[i] + nums[j] + nums[k];
                    bool istrue = true;

                    for(int a = 2; a < number; a++)
                    {
                        if (number % a == 0)
                            istrue = false;
                    }

                    if (istrue == true)
                        answer++;
                }}}

        return answer;
    }
}