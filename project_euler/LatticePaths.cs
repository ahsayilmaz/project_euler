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
        if (k < 0 || k > num)
        {
            return -1;
        }

        if (k==0||k==num)
        {
            return 1;
        }

        if (k > num / 2)
        {
            k = num - k;
        }
        long sonuc = 1;
        for (int i = 1; i <= k; i++)
        {
            sonuc *= (num-i+1)/i;
        }
        return sonuc;
    }

    public static long kafesYolusayisi(int satır, int sütun)
    {
        if (satır <= 0 || sütun <= 0)
        {
            return -1;
        }

        return kombinasyon(satır + sütun - 2, satır - 1);
    }
}