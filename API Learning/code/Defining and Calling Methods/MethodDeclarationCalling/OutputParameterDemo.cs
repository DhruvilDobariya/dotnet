using System;

namespace MethodDeclarationCalling
{
    public class OutputParameterDemo
    {
        public static void Main(string[] args)
        {
            int a, b;

            OutputParameterDemo op = new OutputParameterDemo();
            op.getValues(out a, out b);
            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);

        }
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
}
