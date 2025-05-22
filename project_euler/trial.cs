using project_euler;

public class Trial
{
    public static int Main(int n)
    {
        string num;
        int count = 0;
        for (double i = 3; i <= 1000; i++)
        {
            num = (1/i).ToString();
            int Length = num.Length;
            string sequence="";
            int index = 0;
            for (int j = 2; j < Length; j++)
            {
                if (num[j] == sequence[index])
                {
                    index++;
                    if (index == sequence.Length)
                    {
                        index = 0;
                    }
                }
                else
                {
                    sequence += num[j];
                    index = 0;
                }
            }
        }
        return 0;
    }
}