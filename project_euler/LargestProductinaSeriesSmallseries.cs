namespace project_euler;

public class LargestProductinaSeriesSmallseries
{
    public static int Main(string n)
    {
        int number = int.Parse(n);
        Console.WriteLine(number);
        int largestProduct = 1; 
        int[] digits = new int[4];
        for (int i = 0; i <4; i++)
        {
            largestProduct *= number%10;
            digits[i] = number%10;
            number /= 10;
        }

        for (int i = 0; i < n.Length - 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                digits[j]=number%10;
                number /= 10;
            }
            int tempProduct=digits[0]*digits[1]*digits[2]+digits[3];

            if (largestProduct == tempProduct)
            {
                largestProduct = tempProduct;
            }
        }
        return largestProduct;
    }
}