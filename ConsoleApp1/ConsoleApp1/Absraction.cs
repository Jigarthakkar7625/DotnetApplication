using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Absraction
    {
        public Absraction()
        {

        }
        public abstract void MyMethod(); // Abstaract method

        //public void MyMethod2();

    }

    public class AbsractionA : Absraction
    {
        //public override void MyMethod()
        //{
        //    throw new NotImplementedException();
        //}
        public override void MyMethod()
        {
            throw new NotImplementedException();
        }
    }

    /// Abstraction : 

    // Interface  : multiple inharitance, No Constructor, No Static,No Access modifier(Only  Public),Slow
    // Absract : NO multiple inharitance,  Yes Constructor,  Static, Access modifier, Performace Fast
}
