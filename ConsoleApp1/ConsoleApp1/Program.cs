// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System; //Namespace



int a = (int)days.Sunday;

Dictionary<string, int> myDic = ((days[])Enum.GetValues(typeof(days))).ToDictionary(k => k.ToString(), v => (int)v);


//var authorLevel = AuthorLevels.Platinum.GetEnumDescription();

//FileStream fileStream = null;
//try
//{

int[] ints = new int[10];

//2*2 = 4
//string[,] ints = new string[3, 3]; // 2D
//string[,,] strings = new string[2, 2, 2]; //3D


//ints[0, 1] = "string";
//ints[1, 2] = "string1";
//ints[2, 0] = "string2";

//string[][] ints = new string[3][];

//ints[0] = new string[10];
//ints[5] = new string[15];





foreach (var item in ints)
{
    Console.WriteLine(item);
}

GET("jigar", "Mehul", true, 1, 10.5, "Nidhi");
//GET(ints);

//GET1("Jigar", "Nidhi");

var objects = new object[10];
objects[0] = "JIgar";
objects[1] = 1;
objects[2] = true;

Demo2.test();

Console.WriteLine(Demo2.PI);

static void GET(params object[] ints)
{

    //foreach (var item in ints)
    //{
    //    Console.WriteLine(item);

    //}
}


//static void GET(params int[] ints)
//{
//    foreach (var item in ints)
//    {
//        Console.WriteLine(item);

//    }
//}

//for (int i = 0; i < length; i++)
//{

//}

// For
// foreach

// Array

//1.  Single D A
//2. Multi D A
//3.Jagged array


//List<string> list = new List<string>();


//FileInfo fileInfo = new FileInfo("D:\\Jigar FrontEnd\\Angular\\AngularJavaBatchMPMRM\\DotnetApplication\\demo123.txt");

// var a =  fileInfo.DirectoryName;


//if (fileInfo.Exists)
//{
//    fileInfo.Delete();
//}

//DirectoryInfo directoryInfo  =  new DirectoryInfo("D:\\Jigar FrontEnd\\Angular\\AngularJavaBatchMPMRM\\DotnetApplication\\newFolder");


//var files = directoryInfo.GetFiles();
//if (directoryInfo.Exists)
//{
//    directoryInfo.Delete();
//}

//if (fileInfo.Exists)
//{

//}
//else {
//    throw new Exception("File is not exist");
//}

//fileStream = new FileStream("D:\\Jigar FrontEnd\\Angular\\AngularJavaBatchMPMRM\\DotnetApplication\\demo.txt", FileMode.OpenOrCreate);

////fileStream.Write("Mehul");

////StreamWriter streamWriter = new StreamWriter(fileStream);
//StreamReader streamReader = new StreamReader(fileStream);

//var a = streamReader.ReadLine();
//streamReader.Close();
//fileStream.Close();



//Console.WriteLine("test 13vbvcbc");

//string a = "Jigar";

//if (a == "Jigar")
//{
//    // Custom exeption throw
//    throw new Exception("Please enter valid name !");
//}
//try
//{
//    string a
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Nested try catch : " + ex);
//}

//}
//catch (DivideByZeroException ex)
//{
//    if (ex.InnerException != null)
//    {
//        Console.WriteLine("This is DivideByZeroException : " + ex.InnerException);
//    }
//    else
//    {
//        Console.WriteLine("This is DivideByZeroException : " + ex);
//    }

//    Console.WriteLine("This is DivideByZeroException : " + ex);
//    //throw;
//}
//catch (NullReferenceException ex)
//{
//    Console.WriteLine("This is NullReferenceException : " + ex);
//    //throw;
//}
//catch (InvalidCastException ex)
//{
//    Console.WriteLine("This is InvalidCastException : " + ex);
//    //throw;
//}
//catch (IOException ex)
//{
//    Console.WriteLine("This is InvalidCastException : " + ex.InnerException);
//    //throw;
//}

//catch (FieldAccessException ex)
//{
//    Console.WriteLine("This is FieldAccessException : " + ex);
//    //throw;
//}
//catch (Exception ex)
//{
//    Console.WriteLine("This is Exception : " + ex);
//    //throw;
//}
//finally
//{
//    fileStream.Close();
//    Console.WriteLine("Always Execute!!");
//}





//    Console.WriteLine("After try");
//Console.ReadLine();





//Console.WriteLine("Hello, World!");

//var a = 30;

//Console.WriteLine(a);


//int myInt = 10; /// Value type
//int myInt2 = 20; /// Value type

//int myInt4 = 10; /// Value type
//int myInt5 = 20; /// Value type

//object myObj = null; // Boxing // Assignment operator

//int myInt2 = (int)myObj; // Unboxing
//int myInt3 = Convert.ToInt32(myObj); // Unboxing

//int myInt2 = 10;
//myInt2 *= 5;

//myInt2 = myInt2 * 5;

//bool v = true;

//if (v)
//{
//    Console.WriteLine("inside loop");
//}
//else if (true)
//{

//}
//else if (true)
//{

//}
//else if (true)
//{

//}
//else
//{
//    Console.WriteLine("outside loop");
//}


//for (int i = 0; i < length; i++)
//{

//}

//int intSwitch = 100;

//switch (intSwitch)
//{
//    case 1:
//    case 2:
//    case 5:

//    case 10:
//    case 11:
//        Console.WriteLine(4);
//        break;
//    default:
//        Console.WriteLine("100 Print");
//        break;
//}

//ternary operator :




//a = (myInt == myInt2) ? 20 : 30;

//if (true)
//{
//    a = 20;
//}
//else
//{
//    a = 30;
//}
//int a = 10;
//for (int i = 0; i < a; i++)
//{

//    if (i == 3)
//    {
//        break; // Break statement
//    }
//    Console.WriteLine("break Statement  " + i);
//}

//ineligible:
//Console.WriteLine("You are not eligible to vote!");

//Console.WriteLine("Enter your age:\n");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age < 18)
//{
//    goto ineligible;
//}
//else
//{
//    Console.WriteLine("You are eligible to vote!");
//}  

//}  
//for (int i = 0; i < a; i++)
//{

//    if (i == 3)
//    {
//        goto MyGotoStatement; // Break statement
//    }
//    Console.WriteLine("break Statement  " + i);
//}




//while (a == 0)
//{
//    Console.WriteLine("while " + a);
//    a++;
//}

//do
//{
//    Console.WriteLine("do " + a);
//    a++;
//} while (a == 0);


//MyGotoStatement: // GO TO
//Console.WriteLine("My Goto Statement ");

//Console.ReadKey();


//foreach (var item in a)
//{

//}


//Console.WriteLine(myInt3);

//int varInteger = 10;
//long varLong = 605;
//float varFloat = 50.123456f;
//double varDouble = 51.2554;
//bool varBool = false;
//char varChar = 'B';
//string varString = "Jigar Thakkar";

//// Implicit type : 

////double varDoubleImplicit = varInteger; /// Implicit type

////Console.WriteLine(varDoubleImplicit);


//int varIntDouble = (int)varDouble;
//int varIntDouble1 = Convert.ToInt32(varDouble);

////Console.WriteLine(varIntDouble); /// Explicit type casting
////Console.WriteLine("\n"); /// Explicit type casting
////Console.WriteLine(varIntDouble1); /// Explicit type casting
////var a = 30;

//var b = varInteger + varLong;

//int a = 5;
//Console.WriteLine("a++ :" + a++);
//Console.WriteLine("++a :" + ++a);
//Console.WriteLine("a :" + a);

//Console.WriteLine("\n");

//int y = 5;
//Console.WriteLine("y++ :" + y++);
//Console.WriteLine("++y :" + ++y);


//demo obj = new demo();
////demo obj1 = new demo();
////demo obj2 = new demo();
////demo obj3 = new demo();

//obj.UserId = 15;
//obj.UserName = "Jigar Thakkar";

//int b = 30;
////Console.WriteLine("SUM :" + sum(10));

//sum(ref obj);

//Console.WriteLine(b);

//static int sum(ref demo demo) // As A Value
//{

//    demo.UserId = 60;

//    demo.UserName = "Mehul Thakkar";


//    //aAsValue = 15;
//    return 15;
//    //return a + b;
//}
//Demo2 demo2 = new Demo2();

//demo2.checkRefDemo2();

//Console.ReadLine();

//Demo2 demo = new Demo2();
//demo.UserNameDemo2 = "Manthan";
//Demo2.checkRefDemo3(demo);
//Console.ReadLine();

//out 

//int b = 10;
//getOut(out b);
//Console.WriteLine("Value of B :" + b);
//static void getOut(out int val) {

//    val = 20;
//    val *= val;

//}

// Recursion

//Console.WriteLine("5! : " + fectorial(5));




//static int fectorial(int a)
//{

//    if (a == 0) return 1;

//    return a * fectorial(a - 1);

//}



//string str = "Jigar";

//string c = str.PadLeft(8,' ');

//string[] answer = str.Split(',');

//foreach (var item in answer)
//{
//    Console.WriteLine(item);
//}

//string str1 = " Jigar ";

////string answer = $"Welcome {str}";

//Boolean ans = str.Equals(str1);

////string ans = string.Concat(str, str1);

//Console.WriteLine(ans);