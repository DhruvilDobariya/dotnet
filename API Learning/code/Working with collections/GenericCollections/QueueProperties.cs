namespace GenericCollections
{
    public class QueueProperties
    {
        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Dhruvil");
            queue.Enqueue("Dhaval");
            queue.Enqueue("Jenil");
            queue.Enqueue("Bhargav");

            Console.WriteLine(queue.Count);
        }
    }
}
