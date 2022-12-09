using System;

namespace DatatypeDemo
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            //Initialization
            int a = 20;
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            //Implicit conversion
            double implicitlyA = a;
            Console.WriteLine(implicitlyA);
            Console.WriteLine(implicitlyA.GetType());

            //Explicit conversion
            int explicitA = (int)(implicitlyA);
            Console.WriteLine(explicitA);
            Console.WriteLine(explicitA.GetType());

        }
    }
}
