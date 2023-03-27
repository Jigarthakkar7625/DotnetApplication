using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class A
    {
        public int AUserName { get; set; }

        //public A()
        //{
        //    Console.WriteLine("Constructor Called");
        //}

        public virtual void MethodA()
        {
            Console.WriteLine("MethodA Called");
        }
        //public int MethodA(int a, int b, int d)
        //{
        //    return 1;
        //    //Console.WriteLine("MethodA Called");
        //}

    }

    // A : Parent Clas : Base class
    // B : Child Class : Derived class
    public class B : A
    {

        //public int BUserName { get; set; }

        public override void MethodA()
        {
            Console.WriteLine("MethodB Called");
        }


    }

    public class C : B
    {
        public int CUserName { get; set; }

        public void MethodC()
        {
            Console.WriteLine("MethodB Called");
        }


    }

    // Interface : 

    interface IA
    {
        //int a = 10;
        public int MyProperty { get; set; }
        string HelloA(int a);

        string HelloABB(int a);
    }


    interface IB
    {

        string HelloB(int a, int b);
    }

    public class IC : IA, IB
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string HelloA(int a)
        {

            Console.WriteLine("HelloA Called");
            return "";
        }

        public string HelloABB(int a)
        {
            throw new NotImplementedException();
        }

        public string HelloB(int a, int b)
        {
            Console.WriteLine("HelloA Called");
            return "";
        }

        public void GET()
        {
            int a = 10;
        }
    }

}
