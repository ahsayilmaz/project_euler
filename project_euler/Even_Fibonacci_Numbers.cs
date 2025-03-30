namespace project_euler;

public class Even_Fibonacci_Numbers
{
    public static int Main(int n)
    {
        int sum = 0;
        int fibo1 = 1;
        int fibo2 = 0;
        int fibo3 = 0;
        while (fibo2 < n)
        {
            if(fibo2%2==0)
                sum += fibo2;
            fibo3=fibo1 + fibo2;
            fibo2 = fibo1;
            fibo1 = fibo3;
        }
        return sum;
    }
}