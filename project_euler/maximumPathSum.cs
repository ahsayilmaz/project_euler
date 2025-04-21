namespace project_euler;

public class maximumPathSum
{
    public static int Main(string sayi)
    {
        string[] inputs = sayi.Split('\n');
        int[][] triangle = new int[inputs.Length][];
        for (int i = 0; i < inputs.Length; i++)
        {
            triangle[i] = inputs[i].Split(' ').Select(int.Parse).ToArray();
        }
        
        int length = inputs.Length;
        
        for (int row = length-2; row >=0; row--)
        {
            for (int col = 0; col < triangle[row].Length; col++)
            {
                triangle[row][col] += Math.Max(triangle[row+1][col],triangle[row+1][col+1]);
            }
        }
        
        return triangle[0][0];
    }
}