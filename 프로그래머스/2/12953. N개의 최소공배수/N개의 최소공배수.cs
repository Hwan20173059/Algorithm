public class Solution {
    public int solution(int[] arr) {
        int gcd = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            gcd = gcd * arr[i] / coutgcd(gcd, arr[i]);
        }

        return gcd;
    }

    int coutgcd(int a , int b)
    {
        if (b == 0) return a;
        else return coutgcd(b, a % b);
    }
}