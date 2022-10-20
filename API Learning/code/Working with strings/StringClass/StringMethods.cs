using System;

namespace StringClass
{
    public class StringMethods
    {
        public static void Main(string[] args)
        {
            string str = "Dhruvil Dobariya";

            // Position releted methods:
            Console.WriteLine("Position Releted Methods");

            Console.WriteLine(str.IndexOf('D')); // Return : Index of first occurance, Arg 1: character or string which you want to get it's index, If character or string can't exist in string then it should return -1.

            char[] chars = "I am .Net Developer".ToCharArray();
            Console.WriteLine(str.IndexOfAny(chars)); // Return first occurance if  any character of is exist on string other wise it should return 0, Arg 1: array of character.

            Console.WriteLine(str.LastIndexOf('D')); // Return : Index of last occurance, Arg 1: character or string which you want to get it's index, If character or string can't exist in string then it should return -1.

            Console.WriteLine(str.LastIndexOfAny(chars)); // Return last occurance if  any character of is exist on string other wise it should return 0, Arg 1: array of character.

            Console.WriteLine(str.Contains(chars.ToString())); // Return: if string is exist then return true otherwise it should return false.
            Console.WriteLine(str.EndsWith('a')); // Return: if string is end with specify charachter or string return true otherwise it should return false.
            Console.WriteLine(str.StartsWith('H')); // Return: if string is start with specify charachter or string return true otherwise it should return false.

            // Deal with two string
            Console.WriteLine("Deal with two String");

            string str2 = "I am a .Net Developer";
            Console.WriteLine(str.CompareTo(str2)); // Return : first index where start to match strings, if not match then return 0
            Console.WriteLine(String.Compare(str, str2)); // Return : first index where start to match strings, if not match then return 0
            string str3 = String.Concat(str, str2);
            Console.WriteLine(str3);

            str.CopyTo(0, str3.ToCharArray(), 5, 10);
            Console.WriteLine(str3);

            Console.WriteLine(str.Equals(str2)); // Return: if string is equal with specify string return true otherwise it should return false.

            // Get string proparties
            Console.WriteLine("Get Strings Proparties");

            CharEnumerator en = str.GetEnumerator();

            Console.WriteLine(str.GetHashCode());

            Console.WriteLine(str.GetType());

            Console.WriteLine(str.GetTypeCode());

            // String Maniuplation
            Console.WriteLine("String Manupilation");

            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

            string str4 = str.Replace('a', 'h');
            Console.WriteLine(str4);

            string[] strings = str.Split(" ");
            Console.WriteLine(strings[0]);
            Console.WriteLine(strings[1]);

            string str5 = "    Dhruvil Dobariya    ";
            Console.WriteLine(str5.TrimStart());
            Console.WriteLine(str5.TrimEnd());
            Console.WriteLine(str5.Trim());

            Console.WriteLine(str.PadLeft(4, ' '));
            Console.WriteLine(str.PadRight(4, 'i'));

            Console.WriteLine(String.Join("_", strings));

            Console.WriteLine(str5.Normalize());

            Console.WriteLine(str.Insert(16, " is a .Net Developer"));
            Console.WriteLine(str.Remove(7, 4));
        }
    }
}
