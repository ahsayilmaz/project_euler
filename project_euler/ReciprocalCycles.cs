using project_euler;

public class ReciprocalCycles
{
    public static int Main(int n)
    {
        string num;
        int longest = 0;
        for (double i = 3; i < n; i++)
        {
            num = (1 / i).ToString();
            int Length = num.Length;
            for (int j = 2; j < Length; j++)
            {
                if (num[j] != '0')
                {
                    num = num.Substring(j);
                    Length = num.Length;
                    break;
                }
            }
            string sequence = num[0].ToString();
            int index = 0;
            for (int j = 1; j < Length; j++)
            {
                if (num[j] == sequence[index])
                {
                    sequence += num[j];
                    index = 0;
                }
                else
                {
                   index++;
                    if (index == sequence.Length)
                    {
                       index = 0;
                    }
                }
            }
            if(sequence.Length > longest)
            {
                longest = sequence.Length;
            }
        }
        return longest;
    }
}