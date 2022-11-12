namespace GenericCollections
{
    public class StackProperties
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("Dhruvil");
            stack.Push("Dhaval");
            stack.Push("Dhruv");
            stack.Push("Jenil");

            Console.WriteLine(stack.Count);
        }
    }
}
