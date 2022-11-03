using System.Collections;

namespace DisplayCollection
{
    public static class Display
    {
        public static void DisplayList(ICollection list)
        {
            if (list.Count != 0)
            {
                foreach (string item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
    }
}
