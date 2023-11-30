// See https://aka.ms/new-console-template for more information
int a = 100;
float b = 250.0f;
string c = "CSharp";
float f1 = 123.4f;
int i1 = 2000;

// strings and variables can be treated much like a python ''.format()
Console.WriteLine("The values are {0}, {1}, {2}", a,b,c);

// Optionally the variables can be used instead of 0 1 2 representing them if a $ is placed in front
Console.WriteLine($"The values are {a}, {b}, {c}");

// Expressions can be aclled from within the string
Console.WriteLine($"(a + b)/b is {(a + b )/ b}");

// It is also possible to call functions from inside a string 
Console.WriteLine($"{c} in upper-case is {c.ToUpper()}");

// String formatting, the values inside the {} are {variable index, position}, position is calculated from 0 with negative being left aligned and positive being right aligned
Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
Console.WriteLine("{0, -15} {1, 10}", f1, i1);

// String formatting with interpolation
Console.WriteLine("{0, -15} {1, 10}", "Float Val", "Int Val");
Console.WriteLine($"{f1, -15} {i1, 10}");

// String manipulation
string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "This is a STRING";
string[] strs = {"one", "two", "three", "four"};

// Print string length using the built in Length function, note that capitalisation is important
Console.WriteLine(str1.Length);

// It is also possible to access specific chars within a string with indexing, C# uses 0 indexing§
Console.WriteLine(str1[4]);

// Can use foreach loop to iterate over a string, note that the "" and '' are important differentiators between string and char
foreach (char ch in str1){
    Console.Write(ch);
    if (ch == 'b'){
        Console.WriteLine();
        break;
    }
}

// String concatonation, again capitalisation is important "string" is a variable, "String" is a class
String outstr;

outstr = String.Concat(strs);

outstr = String.Join('.', strs);

Console.WriteLine(outstr);

outstr = String.Join("---", strs);

Console.WriteLine(outstr);

// String comparison
bool isEqual = str2.Equals(str3);

Console.WriteLine(isEqual);

int result = string.Compare(str2, "This is a string");

Console.WriteLine($"{result}");

// Replace function
string outstr1 = str1.Replace("fox", "cat");
Console.WriteLine(outstr1);

// Searching string content
string teststr = "The quick brown fox jumps over the lazy dog.";

Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

Console.WriteLine($"{teststr.StartsWith("The", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.EndsWith("dog.", StringComparison.CurrentCultureIgnoreCase)}");

// indexof and lastindexof
Console.WriteLine($"{teststr.IndexOf("fox")}");
Console.WriteLine($"{teststr.LastIndexOf("the")}");
