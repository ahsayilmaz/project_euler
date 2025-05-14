namespace project_euler;

public class FactorialDigitSum
{
    public static int Main(int n)
    {
        int fact = 1;
        for (int i = 2; i <= 12; i++)
        {
            fact *= i;
        }
        string factStr = fact.ToString();
        for (int i = 13; i <= n; i++)
        {
            string tempFact = "";
            int carry = 0;
            foreach (char c in factStr.Reverse())
            {
                int digit = c - '0';
                int product = digit * i + carry;
                tempFact = product % 10 + tempFact;
                carry = product / 10;
            }
            if (carry > 0)
            {
                tempFact = carry + tempFact;
            }
            factStr = tempFact;

        }
        int sum = 0;
        for (int i = 0; i < factStr.Length; i++)
        {
            sum += factStr[i] - '0';
        }
        return sum;
    }
}