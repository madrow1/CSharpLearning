// See https://aka.ms/new-console-template for more information

const string filename = "TestFile.txt";

//using(StreamWriter sw = File.CreateText(filename)) {
//   sw.WriteLine("This is a text file.");
//};

Console.WriteLine(File.Exists(filename));

if(File.Exists(filename)) {
    File.Delete(filename);
}
else {
    using(StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

//if (!File.Exists(filename)) {
//    File.WriteAllText(filename, "This is a text file.");
//}

//string content;

//content = File.ReadAllText(filename);
//Console.WriteLine(content);

Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

File.SetAttributes(filename, FileAttributes.ReadOnly);
Console.WriteLine(File.GetAttributes(filename));
