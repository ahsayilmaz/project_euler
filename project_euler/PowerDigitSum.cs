namespace project_euler;

public interface PowerDigitSum
{
    public static int GetPowerDigitSum(int power)
    {
        long powerOf50 = 1024;
        for (int i = 0; i < 4; i++)//until 2^60
        {
            powerOf50 *= 1024;
        }
        string until1000 = (powerOf50*1024).ToString();//2^63
        for (int i = 0; i <16; i++)//keep on calculating the value of powers of 2 until 1000
        {
            string nextPower = "";
            long sum = 0;
            for (int j = until1000.Length-1; j >=0; j--)
            {
                sum += int.Parse(until1000[j].ToString()) * powerOf50;
                nextPower = (sum % 10)+nextPower;
                sum /= 10;
            }
            Console.WriteLine(sum );
            until1000 = sum + nextPower;
        }

        int digitSum = 0;
        for (int i = until1000.Length-1; i >= 0; i--)
        {
            digitSum += int.Parse(until1000[i].ToString());
        }
        return digitSum;
    }
}