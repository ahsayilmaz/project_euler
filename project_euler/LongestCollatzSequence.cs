namespace project_euler;

public class LongestCollatzSequence
{
    public static int Main(int n)
    {
        
        int largestSequence = 0;
        for (int i = n-1; i > 1; i--)
        {
            int sequence = 0;
            int temp = i;
            while (temp!=1)
            {
                if(temp%2==0)
                    temp = temp/2;
                else
                    temp = temp*3+1;
                sequence++;
            }
            if (sequence > largestSequence) largestSequence = sequence;
        }
        return largestSequence;
    }
}