using System;

public class Solution {
    public int[] solution(string s) 
    {
        int zeroCount = 0;
        int loopCount = 0;
        while (s != "1")
        {
            string replaceStr = s.Replace("0", string.Empty);
            int lengthDiff = s.Length - replaceStr.Length;
            zeroCount += lengthDiff;
            loopCount++;
            s = Convert.ToString(replaceStr.Length, 2);
        }

        int[] answer = new int[] { loopCount, zeroCount };
        return answer;
    }
}

// Convert.ToString() : 첫번째 인수에 변환할 값을, 두번째 인수에 몇진수로 변환할건지 값을 입력하면 변환된 값을 문자열로 받을 수 있다.