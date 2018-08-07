using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppTutorial.Tutorials
{
    class AbstractClass : AbstractBaseClass
    {
        public AbstractClass()
        {
            AbstractClass b = new AbstractClass();
            b.print();
        }
       
        public override void print()
        {
            Console.WriteLine("Hello print");
        }
    }

    public abstract class AbstractBaseClass
    {
        public abstract void print();
    }
}
