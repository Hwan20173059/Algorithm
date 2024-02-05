using System;

public class Solution {
    public int solution(int[,] sizes) {
        int width = 0;
        int height = 0;
        int swap = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i,0] > sizes[i, 1])
            {
                swap = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i,1] = swap;
            }
        }

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 0] > width)
            {
                width = sizes[i, 0];
            }
        }

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (sizes[i, 1] > height)
            {
                height = sizes[i, 1];
            }
        }

        return width * height;
    }
}