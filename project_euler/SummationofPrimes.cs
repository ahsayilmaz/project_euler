namespace project_euler;

public class SummationofPrimes
{
    public static long Main(int number)
    {
        long sum = 5; //2 ve 3 varsayıldı
        long tempPrime = 5;
        while (tempPrime < number)
        {
            if (IsPrime(tempPrime))
            {
                sum += tempPrime;
            }

            tempPrime += 2;
            if (IsPrime(tempPrime))
            {
                sum += tempPrime;
            }
            tempPrime += 4;
        }
        return sum;

        bool IsPrime(long number)
        {
            if (number %3==0)
            {
                return false;
            }

            for (int i = 5; i*i <= number; i+=6)
            {
                if (number % i==0||number%(i+2)==0) return false;
            }
            return true;
        }
    }
}