using DisplayCollection;

namespace GenericCollections
{
    public class DictionaryProperties
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"Name","Dhruvil" },
                {"City","Rajkot" },
                {"Collage","Darshan" },
                {"Working at","Microsoft" }
            };

            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary["Name"]);
            Display.DisplayList(dictionary.Keys);
            Display.DisplayList(dictionary.Values);
        }
    }
}
