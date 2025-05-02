namespace project_euler;

public class First1000DigitFibonacciNumber {
    public static int Main(int n)
    {
        long a = 0;
        long b = 1;
        
        while (b.ToString().Length < 19 ) 
        {
            long nextFib = a + b;
            a = b;
            b = nextFib;
        }

        string aVeryLong = a.ToString();
        string bVeryLong = b.ToString();

        while (bVeryLong.ToString().Length < 1000)
        {
            int length = aVeryLong.Length;
            string nextFib ="";
            int sum = 0;
            for (int i = 0; i<length ; i+=17)
            {
                
            }
            
        }

        return 0;
    }
}