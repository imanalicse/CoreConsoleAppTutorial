using System;

/*
    Static members are invoked using class name, where as instance members are invoked using instancees(objects) of the class
    static modifiers are not allowed on static constructors
     
    */
namespace CoreConsoleAppTutorial.Tutorials
{

    class StaticAndInstanceClass
    {
        public StaticAndInstanceClass()
        {
            //Console.WriteLine(Circle.PI);

            Circle C1 = new Circle(5);
            Console.WriteLine("C1 Area = {0}", C1.CalCulateArea());

            Circle C2 = new Circle(6);
            Console.WriteLine("C2 Area = {0}", C2.CalCulateArea());
        }
    }

    public class Circle
    {
        public static float PI;
        int Radius;

        // Static modifiers are not allowed on static constructors
        // Static constructors are used to initize static fields in a class
        // Static Constructor is called only once, no matter how many instances you create.
        //Static constructors are called before instance constructor
        static Circle ()
        {
            Circle.PI = 3.1416F;
            Console.WriteLine("Static constructor called");            
        }

        public Circle(int r)
        {
            Console.WriteLine("Instance constructor called");
            this.Radius = r;
        }

        public float CalCulateArea()
        {
            // Static propertise and method access using name of class
            return Circle.PI * this.Radius * this.Radius;
        }
    }
}
