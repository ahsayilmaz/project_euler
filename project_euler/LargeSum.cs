namespace project_euler;

using System.Collections.Generic;
using System.Text.RegularExpressions;

public class LargeSum
{
    public static long Main(string n)
    {
        string[] temp = n.Split("\n");
        int[][] numbers = new int[temp.Length][];
        for (int i = 0; i < temp.Length; i++)
        {
            int[] number = dokuzHaneliBol(temp[i]);
            numbers[i] = number;
            Console.WriteLine(numbers[i]);
        }
        



        int[] dokuzHaneliBol(string sayi)
        {
            int[] parça = Regex.Split(sayi, ".{1,9}").Select(int.Parse).ToArray();
            return parça;
        }
        return 0;
    }
}