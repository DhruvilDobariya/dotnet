using System.Collections;

namespace NonGenericCollection
{
    public class BitArrayProperties
    {
        public static void Main(string[] args)
        {
            BitArray bitArray = new BitArray(new[] { true, false, true, false });
            // BitArray bitArray1 = new BitArray(new[] { 1, 0, 1, 0 });

            Console.WriteLine(bitArray.Count);
            Console.WriteLine(bitArray.IsReadOnly);
            Console.WriteLine(bitArray.Length);
            Console.WriteLine(bitArray[0]);


        }
    }
}
