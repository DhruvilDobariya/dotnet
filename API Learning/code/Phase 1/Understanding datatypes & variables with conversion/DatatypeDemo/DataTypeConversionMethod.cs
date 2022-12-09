using System;

namespace DatatypeDemo
{
    class DataTypeConversionMethod
    {
        static void Main(string[] args)
        {
            //Initialization
            int a = 20;
            double b = 21.20;
            bool c = true;
            Console.WriteLine("On Initialization");
            Console.WriteLine("Type of a: " + a.GetType());
            Console.WriteLine("Type of b: " + b.GetType());
            Console.WriteLine("Type of c: " + c.GetType());

            //Covert into string
            Console.WriteLine("After Conversation in String");
            string stringA = a.ToString();
            string stringB = b.ToString();
            string stringC = c.ToString();

            Console.WriteLine("Type of stringA: " + stringA.GetType());
            Console.WriteLine("Type of stringB: " + stringB.GetType());
            Console.WriteLine("Type of stringC: " + stringC.GetType());

            //Convert into main datatype
            Console.WriteLine("After Conversation in main datatype");

            Console.WriteLine("Type of stringA: " + Convert.ToInt32(stringA).GetType());
            Console.WriteLine("Type of stringB: " + Convert.ToDouble(stringB).GetType());
            Console.WriteLine("Type of stringC: " + Convert.ToBoolean(stringC).GetType());

        }
    }
}
