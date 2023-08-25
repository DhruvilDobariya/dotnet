using System;
using System.Collections.Frozen;

namespace FrozenLearn
{
    public class FrozenSetLearn
    {
        public static void Main(string[] args)
        {
            // Create a frozen set with some values
            var frozenSet = FrozenSet.Create(new[] { "red", "green", "blue" });

            // Try to modify the frozen set (will throw an exception)
            // frozenSet.Add("yellow");

            // Check if the frozen set contains a value
            Console.WriteLine(frozenSet.Contains("green")); // True

            // Check if the frozen set is a subset of another collection
            Console.WriteLine(frozenSet.IsSubsetOf(new[] { "red", "green", "blue", "yellow" })); // True

            // Enumerate the values in the frozen set
            foreach (var value in frozenSet)
            {
                Console.WriteLine(value);
            }

            // FrozenSet<T>:
            // A read-only set that uses a hash table to store values.
            // It has a similar construction cost and performance characteristics as FrozenDictionary<TKey, TValue>.

            // FrozenSet<T>.Enumerator:
            // A struct that enumerates the values of a FrozenSet<T>.
            // It implements the IEnumerator<T> interface and provides properties such as Current and Value 1.
        }
    }
}
