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

    public static long kombinasyon(int num, int k)
    {
        if (k < 0 || k > n)
        {
            return -1;
        }

        if (k==0||k==n)
        {
            return 1;
        }

        if (k > num / 2)
        {
            k = num - k;
        }
        long sonuc = 0;
        for (int i = 1; i <= k; i++)
        {
            sonuc = sonuc * (num-i+1)/i;
        }
        return sonuc;
    }
}