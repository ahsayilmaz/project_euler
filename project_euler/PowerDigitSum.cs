namespace project_euler;

public interface PowerDigitSum
{
    public static int GetPowerDigitSum(int power)
    {
        long powerOf59 = 1024;
        for (int i = 0; i < 5; i++)//until 2^60
        {
            powerOf59 *= 1024;
        }
        powerOf59 /= 2;
        string until1000 = (powerOf59*8).ToString();//2^62
        for (int i = 0; i <15; i++)//keep on calculating the value of powers of 2 until 992
        {
            string nextPower = "";
            long sum = 0;
            for (int j = until1000.Length-1; j >=0; j--)
            {
                sum += int.Parse(until1000[j].ToString()) * powerOf59;
                nextPower = (sum % 10)+nextPower;
                sum /= 10;
            }
            until1000 = sum + nextPower;
        }
        long powerOf53 = powerOf59/64;
        long remainderSum=0;
        string remainderTemp = "";
        for (int j = until1000.Length-1; j >=0; j--)
        {
            remainderSum += int.Parse(until1000[j].ToString()) * powerOf53;
            remainderTemp = (remainderSum % 10)+remainderTemp;
            remainderSum /= 10;
        }
        until1000= remainderSum + remainderTemp;//last 53 powers added
        
        int digitSum = 0;
        for (int i = until1000.Length-1; i >= 0; i--)
        {
            digitSum += int.Parse(until1000[i].ToString());
        }
        return digitSum;
    }
}