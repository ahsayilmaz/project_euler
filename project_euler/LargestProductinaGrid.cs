namespace project_euler;

public class LargestProductinaGrid
{
    public static int Main(int adjacent, string n)
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
            for (int j = 0; j < gLength; j++)
            {
                for (int k = 0; k < gLength; k++){}
            }
        }
        
        return 0;
    }
}