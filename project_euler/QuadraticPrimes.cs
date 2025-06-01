using project_euler;

public static class QuadraticPrimes
{
    public static int Main(int n)
    {
        int maxPrimes = 0;
        int product = 0;

        for (int i = -n + 1; i < n; i++)
        {
            for (int j = -n; j < n; j++)
            {
                int count = 0;
                for (int k = 0; k < 100; i++)
                {
                    int result = k * k + i * k + j;
                    if (result < 0)
                    {
                        break;
                    }
                }
            }
        }
        return product;
    }
}