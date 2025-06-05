namespace project_euler;

public class DigitFifthpowers
{
    public static int Main(int n)
    {
        int UstSinir = 360000;
        int TotalSum = 0;
        for (int i = 2; i < UstSinir; i++)
        {
            double sum = 0;
            int temp = i;
            while (0 < i)
            {
                sum += Math.Pow((i % 10),n);
                i /= 10;
            }

            if (sum == temp)
            {
                TotalSum += temp;
            }
        }
        
        return TotalSum;
    }
}