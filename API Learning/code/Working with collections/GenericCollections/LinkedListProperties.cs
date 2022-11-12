namespace GenericCollections
{
    public class LinkedListProperties
    {
        public static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("Dhruvil");
            linkedList.AddLast("Dhaval");
            linkedList.AddLast("Jenil");
            linkedList.AddLast("Bhargav");

            Console.WriteLine(linkedList.Count);
            LinkedListNode<string> firstNode = linkedList.First;
            LinkedListNode<string> lastNode = linkedList.Last;

        }
    }
}
