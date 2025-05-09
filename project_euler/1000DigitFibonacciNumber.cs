namespace project_euler;

using System;

public class First1000DigitFibonacciNumber {
    public static int Main(int n)
    {
        int targetDigits = n > 0 ? n : 1000;
        int count = 2;
        string a = "1";
        string b = "1";

        while (b.Length < targetDigits)
        {
            string nextFib = AddLargeNumbers(a, b);
            a = b;
            b = nextFib;
            count++;
        }

        return count;
    }

    private static string AddLargeNumbers(string num1, string num2)
    {
        // Ensure num1 is the longer number
        if (num1.Length < num2.Length)
        {
            string temp = num1;
            num1 = num2;
            num2 = temp;
        }

        string result = "";
        int carry = 0;

        num2 = num2.PadLeft(num1.Length, '0');

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int sum = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + carry;
            carry = sum / 10;
            result = (sum % 10) + result;
        }

        if (carry > 0)
            result = carry + result;

        return result;
    }
}