using System.Collections;

namespace GenericCollections
{
    public class ArrayListProperties
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { "Dhruvil", "Dhaval", "Bhargav", "Jenil" };

            Console.WriteLine(list.Capacity); // Get or Set Nubmer of Elements in List
            Console.WriteLine(list.Count); // Get the count of number of elements.
            Console.WriteLine(list.IsFixedSize);
            Console.WriteLine(list.IsReadOnly);
            Console.WriteLine(list.IsSynchronized);
            Console.WriteLine(list[0]);
        }
    }
}
