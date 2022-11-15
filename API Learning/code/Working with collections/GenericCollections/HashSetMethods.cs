using DisplayCollection;

namespace GenericCollections
{
    public class HashSetMethods
    {
        public static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>() { "Dhruvil", "Dhruvil", "Jenil", "Dhruv", "Bhargav", "Dhaval", "Bhargav" };

            //Display.DisplayList(set);
            hashSet.Add("Dhaval");

            hashSet.Remove("Dhruv");

            HashSet<string> subSet1 = new HashSet<string>() { "Dhruvil" };
            Console.WriteLine(hashSet.IsSubsetOf(subSet1));
            Console.WriteLine(hashSet.IsProperSubsetOf(subSet1));
            Console.WriteLine(subSet1.IsSupersetOf(hashSet));
            Console.WriteLine(subSet1.IsProperSupersetOf(hashSet));

            Console.WriteLine(hashSet.SetEquals(subSet1));

            Console.WriteLine(hashSet.Contains("Dhruvil"));

            string[] arr = new string[5];
            hashSet.CopyTo(arr, 0);
            Display.DisplayList(arr);

            hashSet.EnsureCapacity(3);
            hashSet.TrimExcess();

            hashSet.Clear();

        }
    }
}
