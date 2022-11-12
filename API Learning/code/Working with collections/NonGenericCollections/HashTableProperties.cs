using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class HashTableProperties
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

            Console.WriteLine(hashtable.Count);
            Console.WriteLine(hashtable.IsFixedSize);
            Console.WriteLine(hashtable.IsReadOnly);
            Console.WriteLine(hashtable.IsSynchronized);
            Console.WriteLine(hashtable["Name"]);
            Display.DisplayList(hashtable.Keys); // Get ICollection of Keys
            Display.DisplayList(hashtable.Values); // Get ICollection of Value
        }
    }
}
