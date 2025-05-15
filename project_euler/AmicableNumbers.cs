namespace project_euler;

public class AmicableNumbers
{
    public static int Main(int num)
    {
        int AmicableSum = 0;
        
        for (int i = 2; i < num; i++)
        {
            int sum1 = 0;
            int upperLimit = (int)Math.Sqrt(i);
            for (int j = 1; j < upperLimit; j++)
            {
                if (i % j == 0)
                {
                    sum1 += j;
                    if (j != 1 && j != i / j)
                    {
                        sum1 += i / j;
                    }
                }
            }
            if(sum1 != i)
                {
                    int sum2 = 0;
                    upperLimit = (int)Math.Sqrt(sum1);
                    for (int k = 1; k < upperLimit; k++)
                    {
                        if (sum1 % k == 0)
                        {
                            sum2 += k;
                            if (k != 1 && k != sum1 / k)
                            {
                                sum2 += sum1 / k;
                            }
                        }
                    }
                    if (sum2 == i)
                    {
                        AmicableSum += i;
                    }
                }
        }
        return AmicableSum;
    }
}