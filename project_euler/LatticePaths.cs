namespace project_euler;

public class LatticePaths
{

    public static long kafesYolusayisi(int satır, int sütun)
    {
        if (satır <= 0 || sütun <= 0)
        {
            return -1;
        }
        if (satır <= 0 || sütun<=0)
            return 0;
        long permütasyon = 1;
        long remainder = 1;
        for (int i = satır+1, j=1; i <= satır+sütun; i++, j++)
        {
            if (i%j==0)
                permütasyon *= (i / j);
            else if (permütasyon % j == 0)
            {
                permütasyon = permütasyon / j;
                permütasyon*= i;
            }
            else
            {
                remainder *= j;
                permütasyon *= i;
            }
        }

        return permütasyon/remainder;
    }
}