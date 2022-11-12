using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class StackMethods
    {
        public static void Main(string[] args)
        {

            Stack stack = new Stack();

            Display.DisplayList(stack);

            stack.Push("Dhruvil");
            stack.Push("Dhaval");
            stack.Push("Jenil");
            stack.Push("Bhargav");
            Display.DisplayList(stack);

            stack.Pop();
            Display.DisplayList(stack);

            Console.WriteLine(stack.Peek()); // Return top of the stack element without remove it.
            stack.Clear();
            Display.DisplayList(stack);

            var arr = stack.ToArray(); // Return array of stack.
            Console.WriteLine(arr.ToString());
        }
    }
}
