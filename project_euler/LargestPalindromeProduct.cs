namespace project_euler;

public class LargestPalindromeProduct
{
    public static int Main(int digits)
    {
        int largestPalindrome = 0;
        int altSinir = (int) Math.Pow(10, digits - 1);
        for (int i = (int) Math.Pow(10, digits)-1; i >= altSinir; i--)
        {
            for (int j = i; j>= altSinir; j--)
            {
                int product = i*j;
                if (IsPalindrome(product) && product>largestPalindrome)
                {
                    largestPalindrome = product;
                }
            }
        }

        bool IsPalindrome(int number)
        {
            int tempNumber = number;
            int reversedNum = 0;
            while (tempNumber>0)
            {
                int digit = tempNumber % 10;
                reversedNum = reversedNum*10 + digit;
                tempNumber /= 10;
            }
            return reversedNum == number;
        }

        return largestPalindrome;
    }
}