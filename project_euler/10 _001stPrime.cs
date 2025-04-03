namespace project_euler;

public class _10_001stPrime {
    public static long Main(int n)
    {
        if (n < 1)
        {
            return 0;
        }

        if (n == 1)
        {
            return 2;
        }

        if (n == 2)
        {
            return 3;
        }
        int counter = 2;//2 ve 3 sayıldı
        long i=5;
        for (;counter < n; i += 4)
        {
            if (IsPrime(i))
            {
                counter++;
                if (counter == n)
                {
                    return i;
                }
            }
            i += 2;
            if (IsPrime(i))
            {
                counter++;
                if (counter==n)
                {
                    return i;
                }
            }
        }

        bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number%2==0) return false;
            if (number%3==0) return false;
            for (long j = 5; j*j <= number; j += 6)
            {
                if (number % j == 0) return false;
                if (number % (j + 2) == 0) return false;
            }
            return true;
        }
        
        Console.WriteLine(counter);
        return i;
    }
}