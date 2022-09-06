using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class StringBuilderClass
    {
        public static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("Dhruvil Dobariya",40); // 40 is a capicity.
            str.Append(" is a .Net Developer.");
            Console.WriteLine(str);

            str.Remove(0, 10); // First argument is Starting ndex and seconde one is Length.
            Console.WriteLine(str);

            str.Insert(0, "I am Dhruvil Do");
            Console.WriteLine(str);

            str.Replace(" is a", ". I am"); // First argument is old value and seconde one is the new value.
            Console.WriteLine(str);

            str.Capacity = 51;
            Console.WriteLine(str.Capacity);

            str.Clear();
            Console.WriteLine(str);
        }
    }
}
