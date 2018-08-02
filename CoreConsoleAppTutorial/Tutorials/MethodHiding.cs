using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppTutorial.Tutorials
{
    class MethodHiding
    {
        public MethodHiding()
        {
            //Employee pte = new PartTimeEmployee();
            PartTimeEmployee pte = new PartTimeEmployee();
            pte.Name = "Shahidul Isalm";
            pte.printName();
            //((Employee)pte).printName();

            FullTimeEmployee fte = new FullTimeEmployee();
            fte.Name = "Iman Ali";
            fte.printName();            
        }
    }

    public class Employee
    {
        public string Name { get; set; }        

        public virtual void printName()
        {
            Console.WriteLine($"Name = {this.Name}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printName()
        {
            //base.printName();
            Console.WriteLine($"Name = {this.Name} - part time");
        }
    }

    public class FullTimeEmployee : Employee
    {       
    }

}
