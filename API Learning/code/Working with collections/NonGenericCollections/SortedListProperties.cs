using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class SortedListProperties
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

            Console.WriteLine(sortedList.Capacity);
            Console.WriteLine(sortedList.Count);
            Console.WriteLine(sortedList.IsReadOnly);
            Console.WriteLine(sortedList.IsFixedSize);
            Console.WriteLine(sortedList.IsSynchronized);
            Console.WriteLine(sortedList["Name"]);

            Display.DisplayList(sortedList.Keys);
            Display.DisplayList(sortedList.Values);

        }
    }
}
