namespace project_euler;

public class NumberLetterCounts
{
    public static int Main(int n)
    {
        int sum = 0;
        int[] ones =
        {
            0,
            "one".Length,
            "two".Length,
            "three".Length,
            "four".Length,
            "five".Length,
            "six".Length,
            "seven".Length,
            "eight".Length,
            "nine".Length,
        };
        
        int[] tens =
        {
            0,
            "ten".Length ,
            "twenty".Length ,
            "thirty".Length ,
            "forty".Length ,
            "fifty".Length ,
            "sixty".Length ,
            "seventy".Length ,
            "eighty".Length ,
            "ninety".Length
        };
        
        int[] firstTens =
        {
            0,
            "eleven".Length ,
            "twelve".Length ,
            "thirteen".Length ,
            "fourteen".Length ,
            "fifteen".Length ,
            "sixteen".Length ,
            "seventeen".Length ,
            "eighteen".Length ,
            "nineteen".Length
        };

        for (int i = 1; i < n; i++)
        {
            int twoDigits = i % 100;
            int remainder = i / 100;
            if (twoDigits < 20 && twoDigits>10)
            {
                sum+=firstTens[twoDigits-10];
            }
            else
            {
                sum+=ones[twoDigits%10];
                twoDigits/= 10;
                sum+=tens[twoDigits];
            }

            if (i >= 100)
            {
                sum += ones[remainder] + "hundred".Length;
                if (i % 100 != 0)
                    sum += "and".Length;
            }
        }
        return sum+"onethousand".Length;
    }
}