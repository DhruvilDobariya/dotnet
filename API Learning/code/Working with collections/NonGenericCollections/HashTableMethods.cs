using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class HashTableMethods
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable()
            {
                {"Name", "Dhruvil" },
                {"Collage", "Darshan" },
                {"Working at", "Microsoft" },
                {"City", "Rajkot" }
            };
            Display.DisplayDictionary(hashtable);

            hashtable.Add("Mobile No", "8483859760");
            Display.DisplayDictionary(hashtable);

            hashtable.Remove("Mobile No");
            Display.DisplayDictionary(hashtable);

            Console.WriteLine(hashtable.ContainsKey("Name"));
            Console.WriteLine(hashtable.ContainsValue("Dhruvil"));

            hashtable.Clear();
            Display.DisplayDictionary(hashtable);

        }
    }
}
