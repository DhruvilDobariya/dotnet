using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class QueueMethods
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            Display.DisplayList(queue);

            queue.Enqueue("Dhruvil");
            queue.Enqueue("Dhaval");
            queue.Enqueue("Jenil");
            queue.Enqueue("Bhargav");
            Display.DisplayList(queue);

            queue.Dequeue();
            Display.DisplayList(queue);

            Console.WriteLine(queue.Contains("Dhruvil"));
            Console.WriteLine(queue.Count);
            queue.TrimToSize(); // Trim size of queue
            Console.WriteLine(queue.Count);

            queue.Clear();
            Display.DisplayList(queue);

            var arr = queue.ToArray(); // Return the array of queue
            Console.WriteLine(arr.ToString());

        }
    }
}
