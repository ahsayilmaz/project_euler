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
        
        string powerOf63 = (powerOf59*16).ToString();//2^63
        for (int i = 64; i <= power; i++)//keep on calculating the value of powers of 2 until 1000
        {
            string nextPower = "";
            long sum = 0;
            for (int j = powerOf63.Length; j >=0; j--)
            {
                sum += int.Parse(powerOf63[j].ToString())*powerOf59;
            }
            
        }
        
        return 0;
    }
}