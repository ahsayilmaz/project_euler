namespace project_euler;

public class HighlyDivisibleTriangularNumber
{
    public static int Main(int n)
    {
        int naturalNumber = 2;
        int triangularNumber = 1;
        while (Divisors(triangularNumber)<=n)
        {
            triangularNumber+=naturalNumber;
            naturalNumber++;
        }

        return triangularNumber;
        
        int Divisors(int num)
        {
            int divisorCount = 0;
            int i;
            for (i = 2; i*i <= num; i++)
            {
                
                if (num % i == 0)
                    divisorCount+=2;
            }
            if (i*i==num) divisorCount++;
            return divisorCount;
        }
    }
}