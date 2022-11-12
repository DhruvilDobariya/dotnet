namespace GenericCollections
{
    public class HashSetProperties
    {
        public static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>() { "Dhruvil", "Dhaval", "Jenil", "Dhruv", "Bhargav" }; // Contain unique elements

            Console.WriteLine(hashSet.Count);
        }
    }
}
