namespace project_euler;

public class countingSundays
{
    public static int Main(int start, int end)
    {
        int sundays = 0;
        int whatDay = 0;//0:monday, 7:sunday
        for (int i = start; i <= end; i++)
        {
            whatDay+=31 % 7 - 1;
            if (whatDay%7==6){
                sundays++
                }
        }
        return 0;
    }
}
