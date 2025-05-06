using System;

namespace project_euler
{
    public class First1000DigitFibonacciNumber
    {
        private const int TargetDigitCount = 1000;
        private const int ChunkSize = 17;        
        private const long ModValue = 100000000000000000; 

        public static int FindFirstFibonacciWithNDigits(int digitCount)
        {
            int index = 2; // Fibonacci index starts at 2 (F1 = 1, F2 = 1)
            string a = "0"; // First Fibonacci number
            string b = "1"; // Second Fibonacci number

            while (b.Length < digitCount)
            {
                string nextFib = AddLargeNumbers(a, b);
                a = b;
                b = nextFib;
                index++;
            }

            return index;
        }

        private static string AddLargeNumbers(string num1, string num2)
        {
            // Pad the shorter number with leading zeros
            num1 = num1.PadLeft(num2.Length, '0');
            num2 = num2.PadLeft(num1.Length, '0');

            long carry = 0;
            string result = "";

            // Process chunks of ChunkSize digits from the right
            for (int i = num1.Length; i > 0; i -= ChunkSize)
            {
                int start = Math.Max(0, i - ChunkSize);
                int length = i - start;

                long chunk1 = long.Parse(num1.Substring(start, length));
                long chunk2 = long.Parse(num2.Substring(start, length));

                long sum = chunk1 + chunk2 + carry;
                carry = sum / ModValue;

                // Add the current chunk (padded with zeros if necessary)
                result = (sum % ModValue).ToString().PadLeft(length, '0') + result;
            }

            // Add any remaining carry
            if (carry > 0)
            {
                result = carry + result;
            }

            return result.TrimStart('0'); // Remove leading zeros
        }

        public static void Main(string[] args)
        {
            int index = FindFirstFibonacciWithNDigits(TargetDigitCount);
            Console.WriteLine($"The index of the first Fibonacci number with {TargetDigitCount} digits is: {index}");
        }
    }
}
