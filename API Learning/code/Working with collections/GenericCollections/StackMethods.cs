using DisplayCollection;

namespace GenericCollections
{
    public class StackMethods
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Dhruvil");
            stack.Push("Dhaval");
            stack.Push("Dhruv");
            stack.Push("Jenil");
            Display.DisplayList(stack);

            Console.WriteLine(stack.Pop());
            Display.DisplayList(stack);

            Console.WriteLine(stack.Peek());
            Display.DisplayList(stack);

            Console.WriteLine(stack.Contains("Dhruvil"));
            stack.TrimExcess();

            string[] arr = stack.ToArray();
            Display.DisplayList(arr);

            string[] arr2 = new string[5] { "Dhruvil", "Dhaval", "Jenil", "Bhargav", "Dhruv" };
            Display.DisplayList(arr2);
            stack.CopyTo(arr2, 0);
            Display.DisplayList(arr2);

            stack.Clear();
            Display.DisplayList(stack);

        }
    }
}
