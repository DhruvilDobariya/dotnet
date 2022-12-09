using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class ArrayListMethods
    {
        // System.Collection is mutable/changed
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { "Dhruvil", "Dhaval", "Bhargav", "Jenil" };

            list.Add("Jash");// Add one element
            list.AddRange(new[] { "Dhruv", "Monik" }); // Add multiple element using ICollection
            Display.DisplayList(list);

            list.Insert(1, "Ram");
            list.InsertRange(2, new[] { "Raj", "Shita" });
            Display.DisplayList(list);

            list.Remove("Ram");
            list.RemoveAt(0);
            list.RemoveRange(0, 2);
            Display.DisplayList(list);

            Console.WriteLine(list.Contains("Dhaval"));
            Console.WriteLine(list.IndexOf("Dhaval"));
            Display.DisplayList(list.GetRange(0, 2));

            //list.SetRange(1, new[] { "Dhruvil", "Ram" });
            //Display.DisplayList(list);

            list.Reverse();
            Display.DisplayList(list);

            list.Sort();
            Display.DisplayList(list);

            Console.WriteLine(list.Capacity);
            list.TrimToSize(); // Trim the capacity.
            Console.WriteLine(list.Capacity);

            list.Clear();
            Display.DisplayList(list);

        }
    }
}
