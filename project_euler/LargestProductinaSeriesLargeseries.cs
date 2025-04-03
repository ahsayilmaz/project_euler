namespace project_euler;

public class LargestProductinaSeriesLargeseries
{
    public static int LargestProductinaSeries(string series, int adjacent)
    {
        int largestProduct = 0;
        int length = series.Length;
        for (int i = 0; i < length-adjacent; i++)
        {
            int tempProduct = 1;
            for (int j = 0; j < adjacent; j++)
            {
                tempProduct *= series[i+j] - '0';
            }
            if(tempProduct > largestProduct) largestProduct = tempProduct;
        }
        return largestProduct;
    }
}