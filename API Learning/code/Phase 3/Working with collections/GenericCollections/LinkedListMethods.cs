using DisplayCollection;

namespace GenericCollections
{
    public class LinkedListMethods
    {
        public static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Dhruvil");
            linkedList.AddLast("Dhaval");
            Display.DisplayList(linkedList);

            linkedList.AddFirst("Jenil");
            Display.DisplayList(linkedList);

            linkedList.AddAfter(linkedList.First, "Bhargav");
            Display.DisplayList(linkedList);

            linkedList.AddBefore(linkedList.First.Next, "Dhruv");
            Display.DisplayList(linkedList);

            linkedList.Remove("Bhargav");
            Display.DisplayList(linkedList);

            linkedList.RemoveLast();
            Display.DisplayList(linkedList);

            linkedList.RemoveFirst();
            Display.DisplayList(linkedList);

            Console.WriteLine(linkedList.Contains("Dhruvil"));

            string[] arr = new string[5];
            linkedList.CopyTo(arr, 0);
            Display.DisplayList(arr);

            LinkedListNode<string> node1 = linkedList.Find("Dhruvil");
            LinkedListNode<string> node2 = linkedList.FindLast("Dhruvil");

            linkedList.Clear();
            Display.DisplayList(linkedList);



        }
    }
}
