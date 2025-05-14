namespace project_euler;

public class LargeSum
{
    public static string Main(string n)
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
            if (i < 10)
            {
                first10Digits = lastDigit+first10Digits;
            }
            tempSum = tempSum/10;
        }
        first10Digits = tempSum+first10Digits;
        return first10Digits.Substring(0,10);
    }
}