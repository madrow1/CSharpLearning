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