// See https://aka.ms/new-console-template for more information
string response; 
OperatingSystem thisOS = Environment.OSVersion;

Console.WriteLine("What is your name?");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course, {response}");
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);