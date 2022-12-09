using System;

namespace DatatypeDemo
{
    class Pointer
    {
        static void Main(string[] args)
        {
            unsafe
            {

                // declare variable
                int n = 10;

                // store variable n address 
                // location in pointer variable p
                int* p = &n;
                Console.WriteLine("Value :{0}", n);
                Console.WriteLine("Address :{0}", (int)p);
            }
        }

    }
}
