using System;

namespace DatatypeDemo
{
    class BoxingUnboxing
    {
        static void Main(string[] args)
        {
            //Intialization
            int a = 10;
            Console.WriteLine(a.GetType());

            //Boxing
            Object boxingA = a;
            Console.WriteLine(boxingA.GetType());

            //Unboxing
            int unboxingA = (int)(boxingA);
            Console.WriteLine(unboxingA.GetType());

        }
    }
}
