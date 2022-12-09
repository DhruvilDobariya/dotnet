using System.Text;

namespace StringBuilderClass
{
    public class StringBuilderProparties
    {
        public static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("Dhruvil Dobariya");
            for (int i = 0; i < str.Length; i++) // Proparty 1: Length
            {
                Console.WriteLine(str[i]); // Proparty 2: Index of string
            }
            Console.WriteLine(str.Capacity); // Proparty 3: Current Capacity of String
            Console.WriteLine(str.MaxCapacity); // Proparty 4 : Max Capaity of String
        }
    }
}
