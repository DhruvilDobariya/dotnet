using System;

namespace StringAndStringBuilder
{
    public class StringBasic
    {
        public static void Main(string[] args)
        {
            char[] chars = new char[] { 'd', 'h', 'r', 'u', 'v', 'i', 'l' };
            string str = new string(chars);
            Console.WriteLine(str);
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Dhruvil\n Dobariya");
            Console.WriteLine("Dhruvil\\n Dobariya");

            //MultiLine String
            string str2 = "Dhruvil" +
                          "Dobariya";
            Console.WriteLine(str2);

            //using @
            string str3 = @"Dhruvil
                Dobariya";
            Console.WriteLine(str3);

            string firstName = "Dhruvil";
            string lastName = "Dobariya";
            Console.WriteLine("Firstname : " + firstName + "Lastname : " + lastName);
            Console.WriteLine($"Firstname :  {firstName} Lastname :  {lastName}");

            //String is a immutable.
        }
    }
}
