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
            while (0 < temp)
            {
                sum += Math.Pow((temp % 10),n);
                temp /= 10;
            }
            if (sum == i)
            {
                TotalSum += i;
            }
        }
        
        return TotalSum;
    }
}