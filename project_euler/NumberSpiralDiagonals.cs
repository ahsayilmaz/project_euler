using project_euler;

public static class NumberSpiralDiagonals
{
    public static long Main(int n)
    {
        int sum = 1;
        int currentNum = 1;
        int step = 2;
        while (currentNum < n * n)
        {
            for (int i = 0; i < 4; i++)
            {
                currentNum += step;
                if (currentNum <= n * n)
                {
                    sum += currentNum;
                }
            }
            step += 2;
        }
        return sum;
    }
}