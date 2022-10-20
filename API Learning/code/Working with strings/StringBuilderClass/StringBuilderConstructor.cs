using System.Text;

namespace StringBuilderClass
{
    public class StringBuilderConstructor
    {
        public static void Main(string[] args)
        {
            // Constructor 1:
            StringBuilder str1 = new StringBuilder();

            // Constructor 2:
            StringBuilder str2 = new StringBuilder("Dhruvil Dobariya"); // Arg 1: String
            Console.WriteLine(str2);

            // Constructor 3:
            StringBuilder str3 = new StringBuilder(2); // Arg 1: Current Capacity of String(Number of Characters exist in string)
            Console.WriteLine(str3.Capacity);
            str3.Append("Dhruvil");
            Console.WriteLine(str3);
            Console.WriteLine(str3.Capacity);

            // Constructor 4:
            StringBuilder str4 = new StringBuilder("Dhruvil Dobariya", 40); // Arg 1: String, Arg 2: Current Capacity of String
            Console.WriteLine($"String : {str4} and it's capicity is {str4.Capacity}");

            // Constructor 5:
            StringBuilder str5 = new StringBuilder(2, 8); // Agr 1: Current Capacity of String, Arg 2: Set Max Capacity of String, if we put string which length is grater then mex capacity then it throws exception.
            Console.WriteLine(str5.Capacity);
            Console.WriteLine(str5.MaxCapacity);

            // Constructor 6:
            StringBuilder str6 = new StringBuilder("I am Dhruvil Dobariya, I am .Net Developer.", 5, 16, 16); // Arg 1: String, Arg 2: Starting Index of staring, Arg 3: Length of string from strating index, Arg 4: Capacity of String
            Console.WriteLine(str6);

        }
    }
}
