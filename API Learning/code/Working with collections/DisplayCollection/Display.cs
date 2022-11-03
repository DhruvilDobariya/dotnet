using System.Collections;
using System.Collections.Generic;

namespace DisplayCollection
{
    public static class Display
    {
        public static void DisplayList(ICollection list)
        {
            if (list.Count != 0)
            {
                bool flag = false;
                Console.Write("[ ");
                foreach (var item in list)
                {
                    if (!flag)
                    {
                        Console.Write(item);
                        flag = true;
                    }
                    else
                    {
                        Console.Write($", {item}");
                    }
                    
                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
        public static void DisplayDictionary(ICollection dictionary)
        {
            if (dictionary.Count != 0)
            {
                bool flag = false;
                Console.Write("[ ");
                foreach (DictionaryEntry item in dictionary)
                {
                    if (!flag)
                    {
                        Console.Write("{ "+ item.Key +" : "+ item.Value +" }");
                        flag = true;
                    }
                    else
                    {
                        Console.Write(", { " + item.Key + " : " + item.Value + " }");
                    }

                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("dictionary is empty");
            }
        }
    }
}
