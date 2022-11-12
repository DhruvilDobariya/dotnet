using DisplayCollection;

namespace GenericCollections
{
    public class SortedListMethods
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
            Display.DisplayDictionary<string, string>(sortedList);

            sortedList.Add("Mobile No", "8563689920");
            Display.DisplayDictionary<string, string>(sortedList);

            sortedList.Remove("Mobile No");
            Display.DisplayDictionary<string, string>(sortedList);

            sortedList.RemoveAt(3);
            Display.DisplayDictionary<string, string>(sortedList);

            Console.WriteLine(sortedList.ContainsKey("Name"));
            Console.WriteLine(sortedList.ContainsValue("Dhruvil"));

            Console.WriteLine(sortedList.GetKeyAtIndex(1));
            Console.WriteLine(sortedList.GetValueAtIndex(1));

            Console.WriteLine(sortedList.IndexOfKey("Name"));
            Console.WriteLine(sortedList.IndexOfValue("Dhruvil"));

            sortedList.SetValueAtIndex(1, "Darshan Institute Of Engineering and Technology");
            Display.DisplayDictionary<string, string>(sortedList);

            sortedList.TrimExcess();

            sortedList.Clear();
            Display.DisplayDictionary<string, string>(sortedList);

            
        }
    }
}
