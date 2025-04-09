namespace project_euler;

public class LatticePaths
{
    public static long faktöriyel(int num)
    {
        if (num < 0)
            return -1;
        if (num == 0)
            return 1;
        long faktöriyel = 1;
        for (int i = 1; i <= num; i++)
        {
            faktöriyel *= i;
        }

        return faktöriyel;
    }
}