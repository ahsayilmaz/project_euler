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
                    if (j * j != i)
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

        bool[] isSumOfTwoAbundants = new bool[n + 1];

        for (int i = 0; i < abundantNumbers.Count; i++)
        {
            for (int j = i; j < abundantNumbers.Count; j++)
            {
                int currentSum = abundantNumbers[i] + abundantNumbers[j];
                if (currentSum <= n)
                {
                    isSumOfTwoAbundants[currentSum] = true;
                }
                else
                {
                   break;
                }
            }
        }

        int finalSumOfNonAbundantSums = 0;
        for (int k = 1; k <= n; k++)
        {
            if (!isSumOfTwoAbundants[k])
            {
                finalSumOfNonAbundantSums += k;
            }
        }

        return finalSumOfNonAbundantSums;
    }
}
