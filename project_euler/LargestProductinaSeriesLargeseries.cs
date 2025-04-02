namespace project_euler;

public class LargestProductinaSeriesLargeseries
{
    public static int LargestProductinaSeries(string n, int adjacent)
    {
        
        int[] digits = new int[adjacent];
        int largestProduct = 1;
        for (int i = 0; i < adjacent; i++)
        {
            if (i < n.Length)
            {
                digits[i] = n[n.Length - 1 - i] - '0';
            }
            else
            {
                digits[i] = 0;
            }
            largestProduct *= digits[i];
            n.Remove(n.Length - 1, 1);
        }

        for (int i = 0; i < n.Length-adjacent; i++)
        { 
            int remainder = i % adjacent;
            if (remainder < n.Length)
            {
                digits[remainder] = n[n.Length - 1 - remainder] - '0';
            }
            else
            {
                digits[remainder] = 0;
            }
            largestProduct *= digits[remainder];
            n.Remove(n.Length - 1 - remainder, 1);
            int tempProduct=1;
            for (int j = 0; j < digits.Length; j++)
            {
                tempProduct *= digits[j];
            }
            if (largestProduct < tempProduct) largestProduct = tempProduct;
        }
        
        return largestProduct;
    }
}