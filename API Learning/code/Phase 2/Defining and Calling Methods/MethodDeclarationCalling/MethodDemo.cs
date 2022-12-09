using System;

namespace MethodDeclarationCalling
{
    public class MethodDemo
    {
        public static void Main(string[] args)
        {
            MethodDemo md = new MethodDemo(); // Create an instance of the MethodDemo class.
            int ans = md.Sum(2, 3); // Calling the Method.
            Console.WriteLine(ans);
        }
        public int Sum(int a, int b) // Method Declaration 
        {
            return a + b;
        }
    }
}
