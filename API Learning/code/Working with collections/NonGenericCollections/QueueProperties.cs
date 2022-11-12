using System.Collections;

namespace NonGenericCollection
{
    public class QueueProperties
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("Dhruvil");
            queue.Enqueue("Dhaval");
            queue.Enqueue("Jenil");
            queue.Enqueue("Bhargav");

            Console.WriteLine(queue.Count); // Get Count of Queue Elements

        }
    }
}
