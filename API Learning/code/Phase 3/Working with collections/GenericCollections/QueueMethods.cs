using DisplayCollection;

namespace GenericCollections
{
    public class QueueMethods
    {
        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Dhruvil");
            queue.Enqueue("Dhaval");
            queue.Enqueue("Jenil");
            queue.Enqueue("Bhargav");
            Display.DisplayList(queue);

            Console.WriteLine(queue.Dequeue());
            Display.DisplayList(queue);

            Console.WriteLine(queue.Peek());
            Display.DisplayList(queue);

            Console.WriteLine(queue.Contains("Dhruvil"));

            queue.TrimExcess();

            string[] arr = queue.ToArray();
            Display.DisplayList(arr);

            string[] arr2 = new string[5] { "Dhruvil", "Dhaval", "Jenil", "Bhargav", "Dhruv" };
            queue.CopyTo(arr2, 0);
            Display.DisplayList(arr2);

            queue.Clear();
            Display.DisplayList(queue);

        }
    }
}
