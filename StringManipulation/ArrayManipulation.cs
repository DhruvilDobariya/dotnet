using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class ArrayManipulation
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5, };
            Console.WriteLine(arr.Length);
            foreach (int a in arr) 
            {
                Console.WriteLine(a); 
            }
            int[] arr2 = new int[5] { 6, 7, 8, 9, 10 };
            arr.CopyTo(arr2, 5);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
