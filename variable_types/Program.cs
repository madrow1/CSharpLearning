int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = 3;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");
Console.WriteLine($"{c  + a}");
Console.WriteLine($"{(char)(c + a)}");



s s1;
s1.a = 5;
s1.b = false;
StructOp(s1);


MyClass cl = new MyClass{a = 5, b = false};

ClassOp(cl);

// Declare struct
void StructOp(s theStruct) {
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

// Declare class
void ClassOp(MyClass theClass) {
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

// Classes and structs need to be declared at the end of the program for some reason.
class MyClass {
    public int a;
    public bool b;
}


struct s {
    public int a;
    public bool b;
    
}