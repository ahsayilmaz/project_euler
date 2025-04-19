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
        
        return 0;
    }
}