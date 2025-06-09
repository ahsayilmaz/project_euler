namespace project_euler;

public class coinSums
{
    public static int Main(int n)
    {
        int limit = n * 100;
        int pound = 100;
        int howManyWays= 0;
        for (int i = 0; i <= limit; i+=pound)
        {
            for (int j = 0; j <= limit-i; j += 50)
            {
                for (int k = 0; k <= limit - j-i; k += 20)
                {
                    for (int l = 0; l <= limit - i - j - k; l += 10)
                    {
                        for (int m = 0; m <= limit - i - j - k - l; m += 5)
                        {
                            for (int o = 0; o <= limit - i - j - k - l - m; o += 2)
                            {
                                howManyWays++;
                            }
                        }
                    }
                }
            }
        }
        return howManyWays+1;// +1 for 200 pence which is 2£ it self
    }
}