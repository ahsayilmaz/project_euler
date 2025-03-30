namespace project_euler;

public class Largest_Prime_Factor
{
    public static long Main(long n)
    {
        long largest=0;

        for (int i = 0; i < 7; i++)
        {
            if ((n - i) % 2 == 0 || (n - i) % 3 == 0)
            {
                continue;
            }
            for (int j = 5; j*j < (n - i); j+=6)
            {
                if ((n - i) % j == 0 || (n-i) % (j + 2) == 0)
                {
                    continue;
                }
            }
            largest = (n - i);
            break;
        }
        
        for (long i = 5; i <= n/2; i+=6)
        {
            if (n % i == 0)
            {
                largest = i;
            }else if (n % (i + 2) == 0)
            {
                largest = (i + 2);
            }
        }
        return largest;
    }
}