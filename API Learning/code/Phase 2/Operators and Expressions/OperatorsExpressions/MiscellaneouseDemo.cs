using System;
using System.Text;

namespace OperatorsExpressions
{
    class MiscellaneouseDemo
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine(sizeof(int));
            Console.WriteLine(typeof(StringBuilder));

            // as
            Object obj = new StringBuilder();
            StringBuilder str = obj as StringBuilder;
            // is
            Console.WriteLine(str is StringBuilder);

            Console.WriteLine(a > b ? "a is grater than b" : "b is grater then a");

        }
    }
}
