using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] elements) 
    {
        int[] doubleArray = new int[2 * elements.Length];
        HashSet<int> hash = new HashSet<int>();

        for(int i = 0; i< 2 * elements.Length; i++)
            doubleArray[i] = elements[i%elements.Length];

        for (int i = 0; i < elements.Length; i++) 
        { 
            for(int j = 0; j < elements.Length; j++)
            {
                int[] newArray = doubleArray.Skip(i).Take(j + 1).ToArray();
                hash.Add(newArray.Sum());
            }
        }

        return hash.Count;
    }
}