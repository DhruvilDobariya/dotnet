﻿namespace AssemblyAndNamespace
{
    public class WithFullName
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");

            string str = "I am Dhruvil Dobariya, I am a .Net Developer";
            System.IO.File.WriteAllText(@"D:/dotnet/API Learning/code/Namespace & .Net Library/AssemblyAndNamespace/StaticFile/WriteText.txt", str);
        }
    }
}
