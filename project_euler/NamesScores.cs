using project_euler;

public class NamesScores
{
    public static int Main(string filePath)
    {   
        int totalScore = 0;
        if(!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return 0;
        }
        string[] names = File.ReadAllText(filePath).Split(',');
        Array.Sort(names);
        for (int i = 0; i < names.Length; i++)
        {
            string name = names[i].Trim('"');
            int nameScore = 0;
            foreach (var ch in name)
            {
                if (char.IsLetter(ch))
                {
                    nameScore += char.ToUpper(ch) - 'A' + 1;
                }
            }
            totalScore += nameScore * (i + 1);
        }
        return totalScore;
    }
}