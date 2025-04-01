namespace project_euler;

public class SmallestMultiple
{
    public static long Main(int num)
    {
        int product = 1;
        for (int i = 2; i <= num; i++)
        {
            if (product % i == 0) continue;
            if (i % 2 == 0 && i / 2 >= 1)
                product *= i/(i / 2);

            if (i % 3 == 0 && i / 3 >=1)
                product *= i / (i/3);
            for (int j = 5; j <= i; j+=6)
            {
                if (i % j == 0 && i / j >= 1)
                {
                    product *= i/(i/j);
                }else if (i % (j + 2) == 0 && i / (j + 2) >= 1)
                {
                    product *= i/ (i / (j + 2));
                }
            }
        }
        return product;
    }
}