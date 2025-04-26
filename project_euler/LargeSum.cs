namespace project_euler;

public class LargeSum
{
    public static long Main(string n)
    {
        string[] numbers = n.Split("\n");
        string first10Digits = "";
        int numLength = numbers[0].Length;
        int listLength = numbers.Length;
        int tempSum=0;
        for (int i = numLength-1; i >=0; i--)
        {
            for (int j = 0; j < listLength; j++)
            {
                tempSum += int.Parse(numbers[j][i].ToString());
            }
            int lastDigit = tempSum%10;
            if (i <= 10)
            {
                first10Digits = lastDigit+first10Digits;
            }
            tempSum = tempSum/10;
        }
        first10Digits = tempSum+first10Digits;
        int sum = 0;
        for (int i = 0; i <10; i++)
        {
            sum += int.Parse(first10Digits[i].ToString());
        }
        return sum;
    }
}