using project_euler;

public class ReciprocalCycles
{
    public static int Main(int n)
    {
        string num;
        int longest = 0;
        for (int i = 3; i < n; i++)
        {
            string sequence = "";
            int remainder = 1;
            while (remainder != 0 && !sequence.Contains(remainder.ToString()))
            {
                sequence += remainder.ToString();
                remainder = (remainder * 10) % i;
            }
            if (remainder != 0)
            {
                int cycleLength = sequence.Length - sequence.IndexOf(remainder.ToString());
                if (cycleLength > longest)
                {
                    longest = cycleLength;
                    num = i.ToString();
                }
            }
        }
        return longest;
    }
}