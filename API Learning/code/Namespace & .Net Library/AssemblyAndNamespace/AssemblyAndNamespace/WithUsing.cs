using System;
using System.IO;

namespace AssemblyAndNamespace
{
    public class WithUsing
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            string str = "I am Dhruvil Dobariya, I am a .Net Developer";
            File.WriteAllText(@"D:/dotnet/API Learning/code/Namespace & .Net Library/AssemblyAndNamespace/StaticFile/WriteText.txt", str);
        }
    }
}
