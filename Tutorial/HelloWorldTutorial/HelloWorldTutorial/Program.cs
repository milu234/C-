// See https://aka.ms/new-console-template for more information
using HelloWorldTutorial;
using System.Security.Cryptography.X509Certificates;

var test = "noob" ;
Console.WriteLine(test);

int a = 9;
string b = "ABC";
byte c = 255;
char d = 'A';

Console.WriteLine(a+ b + c + d);

double testDouble = 15.45;
Console.WriteLine(testDouble);

float testFloat = 0.12345367f;
Console.WriteLine(testFloat);

decimal testDecimal = .123456677m;
Console.WriteLine(testDecimal);

// keywords cannot be used as variables

// increment operators
int learnVariable = 1;
learnVariable = learnVariable+ 1;   

Console.WriteLine(learnVariable);

float testFloatVaruable = 0.876f;
testFloatVaruable *= testFloatVaruable;

Console.WriteLine(testFloatVaruable);

int num = 784949303;
long bignum = num;
Console.WriteLine(bignum);


//Stack and heaps
// Stack is for value type and Heap is for reference type.

int testValue = 4;
byte lowLevelValue = 3;
bool boolValue = false;
string stringValue = "String";

StackHeapExample stackHeap = new StackHeapExample();

int ans = stackHeap.AddFive(3);
Console.WriteLine(ans);

// Array is a collection of fixed sets of values

int[] vs = new int[2];

string[] vstr = new string[2];
Console.WriteLine(vs);
Console.WriteLine(vstr);


//Dynamic Array

int[] staticIntArray = new int[] { 6, 8, 9 ,2,3,4,5 };
Console.WriteLine(test);
var x = staticIntArray.Average();

Array.Sort(staticIntArray);

Console.WriteLine(staticIntArray);
Console.WriteLine(x);


//Strings - that store text 

string testString = "test";

char[] lowLevelString = new[] {'t' , 'e', 's', 't' };

String testStringCapital = "TEST";

string message1;

string message2 = null;

//**** Important ***//

// int test = null; integer cannot be null;

//lITERAL vd Verbatim

//Strings are immutable(Read only)

string filepath = "C:\\ProgramFiles";  // Literal
string filepathVerbatim = @"C:\\ProgramFiles";  // Verbaitm 











