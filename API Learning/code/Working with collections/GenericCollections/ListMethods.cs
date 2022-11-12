using DisplayCollection;

namespace GenericCollections
{
    public class ListMethods
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Dhruvil", "Bhargav", "Jenil", "Dhaval" };
            Display.DisplayList(list);

            list.Add("Dhruv");
            Display.DisplayList(list);

            list.AddRange(new[] { "Monik", "Jash" });
            Display.DisplayList(list);

            list.Remove("Jash");
            list.RemoveRange(1, 2);
            Display.DisplayList(list);

            list.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(list.Contains("Dhruvil"));
            Console.WriteLine(list.IndexOf("Dhruvil"));

            list.Insert(2, "Bhargav");
            list.InsertRange(2, new[] { "Jash", "Monik" });
            Display.DisplayList(list);

            list.Reverse();
            Display.DisplayList(list);

            list.Sort();
            Display.DisplayList(list);

            Console.WriteLine(list.BinarySearch("Dhruvil"));

            Console.WriteLine(list.Capacity);
            list.TrimExcess();
            Console.WriteLine(list.Capacity);

            list.Clear();
            Display.DisplayList(list);

        }
    }
}
