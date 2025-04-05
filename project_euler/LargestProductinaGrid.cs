namespace project_euler;

public class LargestProductinaGrid
{
    public static long Main(int adjacent, string n)
    {
        long largestProduct = 0;
        string[] temp = n.Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        int length = temp.Length;
        int[][] grid = new int[length][];
        for (int i = 0; i < length; i++)
        {
            grid[i] = temp[i].Split(' ').Select(int.Parse).ToArray();
        }

        for (int i = 0; i < length; i++)
        {
            int gLength = grid[i].Length;
            for (int j = 0; j < gLength-adjacent; j++)
            {
                int tempProduct = grid[i][j];
                for (int k = j+1; k < adjacent - 1; k++)//yatay
                {
                    tempProduct *= grid[i][k];
                }
                if (tempProduct > largestProduct) largestProduct = tempProduct;
                tempProduct = grid[j][i];
                for (int l = j + 1; l < adjacent - 1; l++)//dikey
                {
                    tempProduct *= grid[l][i];
                }
                if (tempProduct > largestProduct) largestProduct = tempProduct;
            }
        }

        for (int i = adjacent-1; i < length; i++)
        {
            for (int j = 0; j < i+1-adjacent; j++)
            {
                int tempProduct = grid[i-j][j];
                for (int k = 1; k < adjacent; k++)// sağa yatık çapraz
                {
                    tempProduct *= grid[i-j-k][j+k];
                }
                if (tempProduct > largestProduct) largestProduct = tempProduct;
                tempProduct = grid[length-i-1][length-j-1];
                for (int k = 1; k < adjacent; k++)//sağa yatık çapraz 2. yarım
                {
                    tempProduct *= grid[length-(i-j-k)-1][length-(j+k)-1];
                }
                if (tempProduct > largestProduct) largestProduct = tempProduct;
                tempProduct = grid[length-i-1][j];
                for (int k = 1; k < adjacent; k++)//sola yatık çapraz
                {
                    tempProduct *= grid[length-(i-j-k)-1][j+k];
                }
                if (tempProduct > largestProduct) largestProduct = tempProduct;
                tempProduct = grid[i][length-j-1];
                for (int k = 1; k < adjacent; k++)
                {
                    tempProduct *= grid[i-j-k][length-(j + k)-1];
                }
                if (tempProduct > largestProduct) largestProduct = tempProduct;
            }
        }
        
        return largestProduct;
    }
}