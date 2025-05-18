using project_euler;

public class NonAbundantsums
{
    public static int Main(int n)
    {
        List<int> abundantNumbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            int sumOfDivisors = 1;
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    sumOfDivisors += j;
                    if (i % (i / j) == 0)
                    {
                        sumOfDivisors += i / j;
                    }
                }
            }
            if (sumOfDivisors > i)
            {
                abundantNumbers.Add(i);
            }
        }

        bool[] canBeWritten = new bool[n + 1];
        for (int i = 0; i < abundantNumbers.Count; i++)
        {
            for (int j = i; j < abundantNumbers.Count; j++)
            {
                int sum = abundantNumbers[i] + abundantNumbers[j];
                if (sum <= n)
                {
                    canBeWritten[sum] = true;
                }
                else
                {
                    break;
                }
            }
        }

        int totalSum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (!canBeWritten[i])
            {
                totalSum += i;
            }
        }

        return totalSum;
    }
}
