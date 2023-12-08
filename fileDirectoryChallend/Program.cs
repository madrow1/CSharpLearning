internal class Program
{
    private static void Main(string[] args)
    {
        int totalFiles = 0;

        const string filename = "results.txt";

        string workingDir = Directory.GetCurrentDirectory();

        string[] files = Directory.GetFiles(workingDir);

        foreach (string f in files)
        {
            totalFiles++;
        }

        if (File.Exists("results.txt"))
        {
            using(StreamWriter sw = File.AppendText($"Total Number of Files: {totalFiles}"));
        }
        else
        {
            using(StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine($"Total Number of Files: {totalFiles}");
            }
        }

    }
}