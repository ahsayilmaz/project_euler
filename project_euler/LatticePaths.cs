namespace project_euler;

public class LatticePaths
{

    public static double kafesYolusayisi(int satır, int sütun)
    {
        if (satır <= 0 || sütun <= 0)
        {
            return -1;
        }
        if (satır <= 0 || sütun<=0)
            return 0;
        double permütasyon = 1;
        for (double i = satır+1, j=1; i <= satır+sütun; i++, j++)
        {
            permütasyon *= (i / j);
        }

        return permütasyon;
    }
}