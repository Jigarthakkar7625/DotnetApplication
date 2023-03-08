// See https://aka.ms/new-console-template for more information
using System; //Namespace

Console.WriteLine("Hello, World!");

//var a = 30;

//Console.WriteLine(a);

int varInteger = 10;
long varLong = 605;
float varFloat = 50.123456f;
double varDouble = 51.2554;
bool varBool = false;
char varChar = 'B';
string varString = "Jigar Thakkar";

// Implicit type : 

//double varDoubleImplicit = varInteger; /// Implicit type

//Console.WriteLine(varDoubleImplicit);


int varIntDouble = (int)varDouble;
int varIntDouble1 = Convert.ToInt32(varDouble);

//Console.WriteLine(varIntDouble); /// Explicit type casting
//Console.WriteLine("\n"); /// Explicit type casting
//Console.WriteLine(varIntDouble1); /// Explicit type casting
//var a = 30;

var b = varInteger + varLong;

int a = 5;
Console.WriteLine("a++ :" + a++);
Console.WriteLine("++a :" + ++a);
Console.WriteLine("a :" + a);

Console.WriteLine("\n");

int y = 5;
Console.WriteLine("y++ :" + y++);
Console.WriteLine("++y :" + ++y);

//var a = 30;
