namespace project_euler;

public class LargestProductinaSeriesLargeseries
{
    public static long LargestProductinaSeries(string series, int adjacent)
    {
        long largestProduct = 0;
        int length = series.Length;
        for (int i = 0; i < length-adjacent; i++)
        {
            long tempProduct = 1;
            for (int j = 0; j < adjacent; j++)
            {
                tempProduct *= series[i+j] - '0';
            }
            if(tempProduct > largestProduct) largestProduct = tempProduct;
        }
        return largestProduct;
    }
}