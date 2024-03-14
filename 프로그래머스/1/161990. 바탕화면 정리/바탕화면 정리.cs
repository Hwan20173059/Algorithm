using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];

        answer[0] = wallpaper.Length;
        answer[1] = wallpaper[0].Length;

        int curX;
        int curY;

        for(int i = 0; i < wallpaper.Length; i++)
        {
            for(int j = 0; j < wallpaper[i].Length; j++)
            {
                if (wallpaper[i][j] == '#')
                {
                    curX = i;
                    curY = j;
                    
                    if (answer[0] > curX)
                        answer[0] = curX;

                    if (answer[1] > curY)
                        answer[1] = curY;
                    
                    if (answer[2] < curX + 1)
                        answer[2] = curX + 1;

                    if (answer[3] < curY + 1)
                        answer[3] = curY + 1;
                }
            }
        }

        return answer;
    }
}