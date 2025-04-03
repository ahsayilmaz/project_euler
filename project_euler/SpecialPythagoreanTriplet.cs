namespace project_euler;

public class SpecialPythagoreanTriplet
{
    public static int Main(int num)
    {
        for (int a = 1; a < num; a++)
            for (int b = a + 1; b < num; b++)
            {
                int c=num-a-b;
                if (c>b && a * a + b * b == c * c) return a * b * c;
            }
        return 0;
    }
}