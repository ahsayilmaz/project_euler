namespace project_euler;

public class First1000DigitFibonacciNumber {
    public static int Main(int n)
    {
        int First1000Digit=0;
        long a = 0;
        long b = 1;
        
        for (int i = 1; i < n; i++) 
        {
            long nextFib = a + b;
            a = b;
            b = nextFib;
        }

        return First1000Digit;
    }
}