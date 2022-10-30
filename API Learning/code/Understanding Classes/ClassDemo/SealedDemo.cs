using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class SealedDemo
    {
        public static void Main(string[] args)
        {
            SealedClass sc = new SealedClass();
            Console.WriteLine($"Answer is : {sc.Sum(2, 3)}");
        }
    }
    public sealed class SealedClass // It can't inherite or derive in other class.
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

}
