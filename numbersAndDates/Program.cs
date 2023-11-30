// See https://aka.ms/new-console-template for more information
string[] NumStrs = {"  1 ", " 1.45", "-100", "5e+04"};

int testint;
float testfloat;
bool result;

foreach (string str in NumStrs) {
    try {
        testfloat = float.Parse(str);
        Console.WriteLine($"Parsed number is {testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"Parsed number is {testint}");
    }
    catch (FormatException e) {
        Console.WriteLine($"Could not parse '{str}' : {e.Message}");
    }
}

result = int.TryParse(NumStrs[0], out testint);
Console.WriteLine($"{result} -- '{NumStrs[0]}' : {testint}");

result = float.TryParse(NumStrs[1], out testfloat);
Console.WriteLine($"{result} -- '{NumStrs[1]}' : {testfloat}");

// Formatting numerical data
int[] quarters = {1,2,3,4};
int[] sales = {10000,14000,16000,12000};
double[] intlMixPct = {.23,.36,.23,.25};
int val1 = 1234;
decimal val2 = 1234.5678m;

Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");