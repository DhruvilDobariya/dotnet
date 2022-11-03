using System.Collections;

namespace GenericCollections
{
    public class StackProperties
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("Dhruvil");
            stack.Push("Dhaval");
            stack.Push("Jenil");
            stack.Push("Bhargav");


            Console.WriteLine(stack.Count); // Get Count Stack Elements
        }
    }
}
