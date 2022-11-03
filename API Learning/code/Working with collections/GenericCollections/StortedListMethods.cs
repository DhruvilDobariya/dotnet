using DisplayCollection;
using System.Collections;

namespace GenericCollections
{
    public class StortedListMethods
    {
        public static void Main(string[] args)
        {
            SortedList sortedList = new SortedList()
            {
                {"Name", "Dhruvil" },
                {"Collage", "Darshan" },
                {"Working at", "Microsoft" },
                {"City", "Rajkot" }
            };

            sortedList.Add("Mobile No", "8465736480");
            Display.DisplayDictionary(sortedList);

            Console.WriteLine(sortedList.ContainsKey("Name"));
            Console.WriteLine(sortedList.ContainsValue("Dhruvil"));

            Console.WriteLine(sortedList.GetByIndex(0));
            Console.WriteLine(sortedList.GetKey(0));

            Display.DisplayList(sortedList.GetKeyList());
            Display.DisplayList(sortedList.GetValueList());

            Console.WriteLine(sortedList.IndexOfKey("Name"));
            Console.WriteLine(sortedList.IndexOfValue("Dhruvil"));

            sortedList.Remove("Mobile No");
            Display.DisplayDictionary(sortedList);
            sortedList.RemoveAt(0);
            Display.DisplayDictionary(sortedList);

            Console.WriteLine(sortedList.Capacity);
            sortedList.TrimToSize(); // Trim the size of sorted list
            Console.WriteLine(sortedList.Capacity);

            sortedList.Clear();
            Display.DisplayDictionary(sortedList);
        }
    }
}
