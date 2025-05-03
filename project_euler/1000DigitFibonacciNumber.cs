namespace project_euler;

public class First1000DigitFibonacciNumber {
    public static int Main(int n)
    {
        int count = 1;
        long a = 0;
        long b = 1;
        
        while (b.ToString().Length < 19 ) 
        {
            long nextFib = a + b;
            a = b;
            b = nextFib;
            count++;
        }

        string aVeryLong = a.ToString();
        string bVeryLong = b.ToString();
        long modVeryLong = 100000000000000000;

        while (bVeryLong.Length < 1000)
        {
            string nextFib ="";
            long sum = 0;
            for (int i = aVeryLong.Length-1; i>=17; i-=17)
            {
                sum += Convert.ToInt64(aVeryLong.Substring(i-17, 17));
                sum += Convert.ToInt64(bVeryLong.Substring(i-17, 17));
                nextFib = (sum%modVeryLong)+nextFib;
                sum /= modVeryLong;
            }
            nextFib = sum + nextFib;
            if(bVeryLong.Length > aVeryLong.Length)
                nextFib = bVeryLong.Substring(bVeryLong.Length-aVeryLong.Length)+nextFib;
            aVeryLong = bVeryLong;
            bVeryLong = nextFib;
            count++;
        }

        return count;
    }
}