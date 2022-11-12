namespace GenericCollections
{
    public class ListProperties
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Dhruvil", "Bhargav", "Jenil", "Dhaval" };

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list[0]);
        }
    }
}
