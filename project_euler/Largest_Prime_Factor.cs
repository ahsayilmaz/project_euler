namespace project_euler;

public class LargestPrimeFactor
{
    public static long Main(long n)
    {
        long largest=0;
        
        /*for (long i = 5; i <= n/2; i+=6)
        {
            if (n % i == 0)
            {
                largest = i;
            }else if (n % (i + 2) == 0)
            {
                largest = (i + 2);
            }
        }*/

        for (long i = 2; i * i < n; i++)
        {
            if (n % i != 0) continue;
            var tempIndex=i;
            var tempPrime= (n / i);
            if (tempPrime % 2 == 0 || tempPrime % 3 == 0)
                continue;
            for (long j = 5; j * j < tempPrime; j += 6)
            {
                if (tempPrime % i == 0 || tempPrime % (i + 2) == 0)
                {
                    tempIndex++;
                    break;
                }
            }

            if (i == tempIndex)
            {
                largest = tempPrime;
            }
            else
            {
                tempIndex--;
            }
        }

        /*long i = 2;
        while (i <= n)
        {
            if (n % i == 0)
            {
                n= (n / i);
            }
            i++;
        }*/
        return largest;
    }
}