namespace project_euler;

public class Multiples_of_3_or_5
{
    public static int Main(int n)
    {
        int sum = 0;
        int number = 0;
        while (number<n)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                sum += number;
            }
            number++;
        }
        return sum;
    }
}