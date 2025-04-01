namespace project_euler;

public class SumSquareDifference
{
    public static int Main(int num)
    {
        int sumOfSquares = 0;
        int squareOfSum = 0;
        for (int i = 1; i <= num; i++)
        {
            sumOfSquares += i*i;
            squareOfSum += i;
        }
        return squareOfSum*squareOfSum - sumOfSquares;
    }
}