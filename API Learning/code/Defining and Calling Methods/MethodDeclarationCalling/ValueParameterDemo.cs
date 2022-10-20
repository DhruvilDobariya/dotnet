using System;

namespace MethodDeclarationCalling
{
    public class ValueParameterDemo
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            ValueParameterDemo vp = new ValueParameterDemo();

            vp.swap(a, b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

        }
        public void swap(int x, int y)
        {
            int temp;
            temp = x; /* save the value of x */
            x = y; /* put y into x */
            y = temp; /* put temp into y */
        }
    }
}
