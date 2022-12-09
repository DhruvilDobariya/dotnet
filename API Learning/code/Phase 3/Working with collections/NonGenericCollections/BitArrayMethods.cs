using DisplayCollection;
using System.Collections;

namespace NonGenericCollection
{
    public class BitArrayMethods
    {
        public static void Main(string[] args)
        {
            BitArray bitArray = new BitArray(new[] { true, false, true, false });
            BitArray bitArray2 = new BitArray(new[] { true, true, true, true });
            Display.DisplayList(bitArray);
            Display.DisplayList(bitArray2);

            bitArray.And(bitArray2);
            Display.DisplayList(bitArray);

            bitArray.Or(bitArray2);
            Display.DisplayList(bitArray);

            bitArray.Xor(bitArray2);
            Display.DisplayList(bitArray);

            bitArray.Not();
            Display.DisplayList(bitArray);

            bitArray.Set(1, false);
            Display.DisplayList(bitArray);

            bitArray.SetAll(true);
            Display.DisplayList(bitArray);

            Console.WriteLine(bitArray.Get(0));

        }
    }
}
