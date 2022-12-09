using DisplayCollection;
using System.Collections;

namespace GenericCollections
{
    public class SortedListProperties
    {
        public static void Main(string[] args)
        {
            SortedList<string, string> sortedList = new SortedList<string, string>()
            {
                {"Name","Dhruvil" },
                {"City","Rajkot" },
                {"Collage","Darshan" },
                {"Working at","Microsoft" }
            };

            Console.WriteLine(sortedList.Capacity);
            Console.WriteLine(sortedList.Count);
            Console.WriteLine(sortedList["Name"]);
            Display.DisplayList((ICollection)sortedList.Keys); // We just convert System.Collection.ICollection<string> to System.Collection.ICollection
            Display.DisplayList((ICollection)sortedList.Values);



        }
    }
}
