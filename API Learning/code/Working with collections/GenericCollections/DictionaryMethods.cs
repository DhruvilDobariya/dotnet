using DisplayCollection;

namespace GenericCollections
{
    public class DictionaryMethods
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
            Display.DisplayDictionary<string, string>(dictionary);

            dictionary.Add("Mobile No", "8463468390");
            Display.DisplayDictionary<string, string>(dictionary);

            dictionary.Remove("Mobile No");
            Display.DisplayDictionary<string, string>(dictionary);

            Console.WriteLine(dictionary.ContainsKey("Name"));
            Console.WriteLine(dictionary.ContainsValue("Dhruvil"));

            dictionary.EnsureCapacity(3);

            dictionary.TrimExcess();

            dictionary.Clear();
            Display.DisplayDictionary<string, string>(dictionary);

        }
    }
}
