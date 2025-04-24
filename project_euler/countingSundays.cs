namespace project_euler;

public class countingSundays
{
    public static int Main(int start, int end)
    {
        int sundays = 0;
        int whatDay = 0;//0:monday, 6:sunday
        for (int year = start; year <= end; year++)
        {
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            if (year % 4 != 0)
            {
                whatDay--;
            }
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=30 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=30 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=30 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=30 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6)
            {
                sundays++;
            }
        }
        return sundays;
    }
}
