using System.Text;

namespace StringBuilderClass
{
    public class StringBuilderMethods
    {
        public static void Main(string[] args)
        {
            // StringBuilder is mutable

            StringBuilder str = new StringBuilder("I am Dhruvil Dobariya");
            Console.WriteLine(str.ToString());
            Console.WriteLine(str.ToString(5, 16));

            str.Append(", I am .Net Developer");
            Console.WriteLine(str);

            str.Insert(20, "DDDDDD");
            Console.WriteLine(str);

            str.Remove(20, 6);
            Console.WriteLine(str);

            str.Replace("I am", "My name is");
            Console.WriteLine(str);

            char[] chars = new char[40];
            str.CopyTo(11, chars, 0, 16); // Arg 1: Starting Index source where you want to start copy the string, Arg 2: array of character where you want to copy string, Arg 3: Starting index of destination where you want to start past the string, Arg 4: Length of string from startrig index of source.
            foreach (char c in chars)
            {
                Console.Write(c);
            }
            Console.WriteLine();

            StringBuilder str2 = new StringBuilder("Dhruvil Dobariya");
            Console.WriteLine(str.Equals(str2)); // Return: is string is match from another string then it will return true otherwise it will return false.

            str.Clear(); // Clear the string
            Console.WriteLine(str);




        }
    }
}
