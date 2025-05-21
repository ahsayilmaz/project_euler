using System;
using project_euler;

public class LexicographicPermutations
{
    public static long Main(int n)
    {
        char[] currentPermutation = "0123456789".ToCharArray();
        for (int i = 1; i < n; i++)
        {
            int k = -1;
            for (int j = currentPermutation.Length - 2; j >= 0; j--)
            {
                if (currentPermutation[j] < currentPermutation[j + 1])
                {
                    k = j;
                    break;
                }
            }
            if (k == -1)
            {
                break; 
            }

            int l = -1;
            for (int j = currentPermutation.Length - 1; j > k; j--)
            {
                if (currentPermutation[k] < currentPermutation[j])
                {
                    l = j;
                    break;
                }
            }
            (currentPermutation[k], currentPermutation[l]) = (currentPermutation[l], currentPermutation[k]);
            Array.Reverse(currentPermutation, k + 1, currentPermutation.Length - (k + 1));
        }
        return long.Parse(new string(currentPermutation));
    }
}