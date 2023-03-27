// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System; //Namespace
using System.Collections;
using System.Collections.Generic;


// T => Class // Class : Constructor
// T => struct // datatypes
// T => New() // : Constructor :- Parameter less
// T => <Base class> : Parent Class
// T => <Interface> : Interface
// T => U




List<string> list = new List<string>(); // in build
list.Add("Anisha");
var a = list.Count;

int? i = null;



GC_Struct<float> gC_Class12 = new GC_Struct<float>();
GC_Struct<decimal> gC_Class12e = new GC_Struct<decimal>();

// Class
//GC_Struct<int> gC_Class = new GC_Struct<int>();
//gC_Class.Username = 12;
//gC_Class.GC_Struct_GET(15);

//Partial partial = new Partial();
//partial.Username = "Jigar";

//Partial partial1 = new Partial();
//partial1.Username = "Jigar";

//gC_Class.Username = partial;
//gC_Class.GC_Class_GET(partial1);



// Class
GC_Class<Partial> gC_Class = new GC_Class<Partial>(); // Custom

GC_Class<Threading> gC_Class1 = new GC_Class<Threading>(); // Custom

Partial partial = new Partial();
partial.Username = "Jigar";

Partial partial1 = new Partial();
partial1.Username = "Jigar";

gC_Class.Username = partial;
gC_Class.GC_Class_GET(partial1);


// NON - G

// Array List
// Sorted List
// Stack
// Queue
// Hashtable


//ArrayList arrayList = new ArrayList();
//arrayList.Add(true);
//arrayList.Add(1);  
//arrayList.Add("Jigar");  
//arrayList.Add(4.5);  
//arrayList.Add(null);
//var a = arrayList.Count;


//ArrayList.RemoveAt(0);

//List<demo> demo = new List<demo>();
//demo.UserName = "";


//SortedList List = new SortedList();
//List.Add(1, "jigar");
//List.Add(2, true);
//List.Add(3, 7.5);
//List.Add(4, 1);


//Hashtable hashtable = new Hashtable();
//hashtable.Add(1, "jigar");
//hashtable.Add(2, 12);
//hashtable.Add(3, true);
//hashtable.Add("jigards", "jigar");

//var a = hashtable[1];

//hashtable.Remove(2);
//Stack Stack = new Stack();
//Stack.Push("jigar");
//Stack.Push(1);
//Stack.Push(true);

////Stack.Pop();
//Stack.Peek();


////ArrayList.AddRange(demo);

Console.ReadLine();





//HashSet<string> strings = new HashSet<string>();
//strings.Add("Jigar");
//strings.Add("Mehul");
//strings.Add("Jigar");
//strings.Add("Manthan");
//strings.Add("Jigar");
//strings.Add("Jigar");
//strings.Add("Jigar");
//strings.Add("Jigar");
//strings.Add("Jigar");
//strings.Add("Jigar");
//strings.Add("Jigar");
//Console.WriteLine(strings);



//var a = ints.Pop();
////ints.Dequeue();

//var b = ints.Peek();

//var a = ints.Pop();


//Console.WriteLine(ints);

//1.List<t>
//2. Dictionaty <Key, value>
//3. SortedList <Key, value>
//4. Queue<t> : FIFO : 
//5. Stack<t> : LIFO
//6. HashSet<t>

//IDictionary<string, string> data = new Dictionary<string, string>() {
//    {"A","jigar" },
//    {"B","jigar" },
//    {"C","jigar2" }
//};

//SortedList<int,string> list = new SortedList<int, string>();
//list.Add(4, "Jigar3");
//list.Add(1, "Jigar");
//list.Add(3, "Jigar2");
//list.Add(2, "Jigar1");

//IDictionary<int, string> list1 = new Dictionary<int, string>();
//list1.Add(4, "Jigar3");
//list1.Add(1, "Jigar");
//list1.Add(3, "Jigar2");
//list1.Add(2, "Jigar1");



//Console.WriteLine(list);
//Console.WriteLine(list1);

//foreach (var item in list)
//{
//    var a = data.Keys;
//    foreach (var item1 in a)
//    {
//        var c = data[item1];

//    }
//    var b = data.Values;
//}

//Console.WriteLine(data);

//1.List<t>

//List<string> strings = new List<string>() 
//{ 
//    "JIgar",
//    "Mehul",
//    "Anisha",
//    "fsdf",
//    "sdf",
//    "Anisha",
//    "JIgsdfar",
//    "Anisha",
//    "JIgsdfar"
//};

//var a = strings.Select((x, i) => new { x, i })
//                  .Where(x => x.x == "Anisha")
//                  .Select(x => x.i).ToList();

//var a = strings.Contains("jigar22222");

Console.WriteLine("?");

//strings.Add("Jigar");
//strings.Add("Mehul");
//strings.Add("Anisha");
//strings.Add("Jenish");
//strings.Add("Manthan");
//strings.Add("Abhisek");

//foreach (var item in strings)
//{
//    Console.WriteLine(item);
//}

List<demo> demoList = new List<demo>();

List<demo> demoList111 = new List<demo>();

demo demo1 = new demo();
demo1.UserId = 10;
demo1.UserName = "Jigar";
demoList.AddRange(demoList111);

demo demo2 = new demo();
demo2.UserId = 11;
demo2.UserName = "Mehul";
demoList.Add(demo2);


List<demo> demoList1 = new List<demo>()
{
    new demo(){ UserId = 10,UserName = "jigar" },
    new demo(){ UserId = 11,UserName = "Mehul" }
};

foreach (var item in demoList1)
{
    Console.WriteLine(item.UserId + " - " + item.UserName);
}


//var b = demoList1.Find(x => x.UserId == 10);
//var c = demoList1.Where(x => x.UserId == 10).ToList();


Console.WriteLine("");
// Non : Generic colletion :

//1. ArrayList
//2. SortedList
//3. Stack
//4. Queue
//5. Hashtable





//Partial partial = new Partial();
//var c = partial.Username;
//var b = partial.UserId;


//Thread thread = Thread.CurrentThread;
//thread.Name = "this is my thread";
//Console.WriteLine(thread.Name);



//static void myMethod()
//{

//    //for (int i = 0; i < 10; i++)
//    //{
//    Thread thread = Thread.CurrentThread;

//    //if (thread.IsAlive)
//    //{

//    //}

//    Console.WriteLine(thread.Name);
//    //Thread.Sleep(100);
//    //}
//}

//static void myMethod2()
//{

//    //for (int i = 0; i < 5; i++)
//    //{
//    Thread thread = Thread.CurrentThread;
//    Console.WriteLine(thread.Name);
//    //Thread.Sleep(100);
//    //}
//}

//Threading threading = new Threading();

//Thread thread1 = new Thread(new ThreadStart(myMethod));
//Thread thread2 = new Thread(new ThreadStart(myMethod));
//Thread thread3 = new Thread(new ThreadStart(myMethod));

//thread1.Name = "thread1";
//thread2.Name = "thread2";
//thread3.Name = "thread3";



//thread1.Priority = ThreadPriority.Highest;
//thread2.Priority = ThreadPriority.Normal;
//thread3.Priority = ThreadPriority.Lowest;



//thread3.Start();
//thread2.Start();
//thread1.Start();

//thread.Start();
//thread1.Name = "This is thread 1";
////thread.Join();


//thread2.Start();
//thread2.Name = "This is thread 2";
////thread.Join();
////try
////{
////    thread2.Abort();
////}
////catch (Exception)
////{
////    Console.WriteLine("ERROR");
////    //throw;
////}


//thread1.Start();
//thread1.Name = "This is thread 3";

//A a = new A();
//a.MethodA();
//a.MethodA(10);

//B objB = new B(); // Object : Initialize
//objB.MethodA();

// Runtime polymorphism : Method Overriding : Dynamic Binding : Late binding
// Compile time polymorphism : Method Overloading :Static binding : early binding

//IC iC = new IC();
//iC.HelloA(10);
//iC.HelloB(20, 23);

//IA if  = new IA();



//objB.AUserName();


//Class2 class2 = new Class2();
//class2.PublicClass();

// 1. Single
// 2. Multi level inhari
// 3 hirarchical inh
// 4. Hybrid inh
// 5. Multiple inharitance

//Encap /// 
/// Access modifier : 
/// 

// public : Acceess anywhere inside project
// Private : Within { }
// Protected : Class and inharit class
// Internal : Current project assembly.
// Protected  internal : Current project assembly(Parent) + Derive class
// private protected : class + derive class + Wihin assembly


//Inh
//P
//A
//
//

Class2 Class2 = new Class2();

Class2 = null;
GC.Collect();


//Class2 class2 = new Class2("Jigar", 1);
//Class2 class3 = new Class2("Jigar1", 2);
//Class2 class4 = new Class2("Jigar2", 3);
//Class2 class5 = new Class2("Jigar3", 4);
//Class2 class6 = new Class2("Jigar4", 5);


//Class2 class21 = new Class2(class2);

//Console.WriteLine(class2.userid);
//Console.WriteLine(class2.username);

//Console.WriteLine(class3.userid);
//Console.WriteLine(class3.username);

Console.ReadLine();

//int a = (int)days.Sunday;

//Dictionary<string, int> myDic = ((days[])Enum.GetValues(typeof(days))).ToDictionary(k => k.ToString(), v => (int)v);


////var authorLevel = AuthorLevels.Platinum.GetEnumDescription();

////FileStream fileStream = null;
////try
////{

//int[] ints = new int[10];

//2*2 = 4
//string[,] ints = new string[3, 3]; // 2D
//string[,,] strings = new string[2, 2, 2]; //3D


//ints[0, 1] = "string";
//ints[1, 2] = "string1";
//ints[2, 0] = "string2";

//string[][] ints = new string[3][];

//ints[0] = new string[10];
//ints[5] = new string[15];





//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}

//GET("jigar", "Mehul", true, 1, 10.5, "Nidhi");
////GET(ints);

////GET1("Jigar", "Nidhi");

//var objects = new object[10];
//objects[0] = "JIgar";
//objects[1] = 1;
//objects[2] = true;

//Demo2.test();

//Console.WriteLine(Demo2.PI);

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