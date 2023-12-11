internal class Program
{
    private static void Main(string[] args)
    {
        int totalFiles = 0;
        long totalFileSize = 0;
        const string filename = "results.txt";

        string workingDir = Directory.GetCurrentDirectory();

        string[] files = Directory.GetFiles(workingDir);

        foreach (string f in files)
        {
            FileInfo fi = new FileInfo(f);
            totalFiles++;
            totalFileSize += fi.Length;
        }

        if (File.Exists("results.txt"))
        {
            using(StreamWriter sw = File.AppendText(filename))
            {
            sw.WriteLine($"Total number of files is: {totalFiles}");
            sw.WriteLine($"Total file size of Files: {totalFileSize} bytes"); 
            } 
        }
        else
        {
            using(StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine($"Total Number of Files: {totalFiles}");
                sw.WriteLine($"Total file size of Files: {totalFileSize} bytes");            
            }
        }

    }
}