namespace project_euler;

public class NumberLetterCounts
{
    public static int Main(int n)
    {
        int sum = 0;
        Dictionary<int,int> ones = new Dictionary<int, int>()
        {
            { 1, "one".Length },
            { 2, "two".Length },
            { 3, "three".Length },
            { 4, "four".Length },
            { 5, "five".Length },
            { 6, "six".Length },
            { 7, "seven".Length },
            { 8, "eight".Length },
            { 9, "nine".Length }
        };
        
        Dictionary<int,int> tens = new Dictionary<int, int>()
        {
            {10, "ten".Length },
            { 20, "twenty".Length },
            { 30, "thirty".Length },
            { 40, "forty".Length },
            { 50, "fifty".Length },
            { 60, "sixty".Length },
            { 70, "seventy".Length },
            { 80, "eighty".Length },
            { 90, "ninety".Length }
        };
        
        Dictionary<int,int> firstTens = new Dictionary<int, int>()
        {
            { 11, "eleven".Length },
            { 12, "twelve".Length },
            { 13, "thirteen".Length },
            { 14, "fourteen".Length },
            { 15, "fifteen".Length },
            { 16, "sixteen".Length },
            { 17, "seventeen".Length },
            { 18, "eighteen".Length },
            { 19, "nineteen".Length }
        };

        for (int i = 1; i < n; i++)
        {
            int twoDigits = i % 100;
            int remainder = i / 100;
            if (twoDigits < 20 && twoDigits>10)
            {
                sum+=firstTens[twoDigits];
            }
            else
            {
                sum+=ones[twoDigits%10];
                twoDigits/=10;
                sum+=tens[twoDigits];
            }
            sum+=ones[remainder]+"hundredand".Length;
            Console.WriteLine(sum);
        }
        return sum;
    }
}