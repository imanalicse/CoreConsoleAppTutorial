using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppTutorial.Tutorials
{
    class MethodOverloading
    {
        public MethodOverloading()
        {
            Add(10, 20.5F);
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
        }

        public static void Add(int FN, float SN)
        {
            Console.WriteLine($"Sum = {FN + SN}");
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine($"Sum = {FN + SN + TN}");
        }
    }

}
