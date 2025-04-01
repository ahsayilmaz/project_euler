namespace project_euler;

public class _10_001stPrime {
    public static long Main(int n)
    {
        int check_prime1 = 1;
        int check_prime2 = 1;
        int counter = 2;
        long i;
        for (i = 5; counter < n-2; i += 6)
        {
            check_prime1 = check_prime2 = 1;
            if (i % 3 == 0)
                check_prime1=0;
            if ((i + 2) % 3 ==0)
                check_prime2=0;
            for (long j = 5; j * j <= i; j += 6)
            {
                if (i % j == 0 || i % (j + 2) == 0)
                    check_prime1 = 0;
                if ((i + 2) % j == 0 || (i + 2) % (j + 2) == 0)
                    check_prime2 = 0;
            }
            counter += check_prime1+check_prime2;
        }
        for (; counter < n; i++)
        {
            if (i % 3 == 0) check_prime1=0;
            for (long j = 5; j*j < i; j+=6)
            {
                if (i % j == 0||i%(j+2)==0)
                {
                    check_prime1=0;
                }
            }
            counter += check_prime1;
            check_prime1=1;
        }
        
        Console.WriteLine(counter);
        return i;
    }
}