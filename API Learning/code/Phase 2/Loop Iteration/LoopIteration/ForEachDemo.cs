using System;
using System.Collections.Generic;

namespace LoopIteration
{
    class ForEachDemo
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() { "Dhruvil", "Dhaval", "Bhargav", "Jenil", "Jash", "Dhruv", "Yash" };

            foreach (string std in students)
            {
                Console.WriteLine(std);
            }
        }
    }
}
