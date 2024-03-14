using System;

public class Solution {
    public int[] solution(string[] wallpaper){
        int[] answer = new int[4];

        answer[0] = wallpaper.Length;
        answer[1] = wallpaper[0].Length;

        for(int i = 0; i < wallpaper.Length; i++)
        {
            for(int j = 0; j < wallpaper[i].Length; j++)
            {
                if (wallpaper[i][j] == '#')
                {                     
                    if (answer[0] > i)
                        answer[0] = i;

                    if (answer[1] > j)
                        answer[1] = j;
                    
                    if (answer[2] < i + 1)
                        answer[2] = i + 1;

                    if (answer[3] < j + 1)
                        answer[3] = j + 1;
                }
            }
        }

        return answer;
    }
}