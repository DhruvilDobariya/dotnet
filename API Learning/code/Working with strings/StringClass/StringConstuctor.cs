using System;

namespace StringAndStringBuilder
{
    public class StringConstuctor
    {
        public static unsafe void Main(string[] args)
        {
            // Constructor 1:
            String str = new String(new[] { 'D', 'h', 'r', 'u', 'v', 'i', 'l' });
            Console.WriteLine(str);

            // Constructor 2:
            char[] chars = "Dhruvil".ToCharArray();
            fixed (char* p = chars)
            {
                String str2 = new String(p);
                Console.WriteLine(str2);
            }

            // Constructor 3:
            String str3 = new String('D', 7); // Arg 1: char, Arg 2: number of time occured
            Console.WriteLine(str3);

            // Constructor 4:
            String str4 = new String("Dhruvil Dobariya".ToCharArray(), 7, 4); // Arg 1: array of char, Arg 2: starting index, Arg 2: length from starting index
            Console.WriteLine(str4);

            // Constructor 5:
            char[] chars2 = "Dhruvil Dobariya".ToCharArray();
            fixed (char* p = chars2)
            {
                String str5 = new String(p, 7, 4); // Arg 1: pointer array of char, Arg 2: starting index, Arg 2: length from starting index
                Console.WriteLine(str5);
            }

            //sbyte[] chars3 = new sbyte[7] { 1, 2, 3, 4, 5, 6, 7 };
            //fixed (sbyte* p = chars3)
            //{
            //    String str6 = new String(p); // Arg 1: pointer array of char, Arg 2: starting index, Arg 2: length from starting index
            //    Console.WriteLine(str6);
            //}

            //sbyte[] chars4 = new sbyte[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //fixed (sbyte* p = chars4)
            //{
            //    String str7 = new String(p); // Arg 1: pointer array of char, Arg 2: starting index, Arg 2: length from starting index
            //    Console.WriteLine(str7, 4,7);
            //}

        }
    }
}
