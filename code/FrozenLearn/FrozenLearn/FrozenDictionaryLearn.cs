using System;
using System.Collections.Frozen;

namespace FrozenLearn
{
    public class FrozenDictionaryLearn
    {
        public static void Main(string[] args)
        {
            // Create a frozen dictionary with some key-value pairs
            var frozenDict = FrozenDictionary.Create(new[]
            {
                new KeyValuePair<string, int>("one", 1),
                new KeyValuePair<string, int>("two", 2),
                new KeyValuePair<string, int>("three", 3)
            });
            // Try to modify the frozen dictionary (will throw an exception)
            // frozenDict.Add("four", 4);

            // Check if the frozen dictionary contains a key
            Console.WriteLine(frozenDict.ContainsKey("two")); // True

            // Get the value associated with a key
            Console.WriteLine(frozenDict["three"]); // 3

            // Enumerate the key-value pairs in the frozen dictionary
            foreach (var pair in frozenDict)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

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

            // FrozenDictionary<TKey, TValue>:
            // A read-only dictionary that uses a hash table to store key - value pairs.
            // It has a relatively high construction cost, but offers excellent lookup performance.

            // FrozenDictionary<TKey,TValue>.Enumerator:
            // A struct that enumerates the elements of a FrozenDictionary<TKey,TValue>.
            // It implements the IEnumerator<KeyValuePair<TKey,TValue>> interface and provides properties such as Current and Key 1.
        }
    }
}

// System.Collections.Frozen
// System.Collections.Frozen is a new namespace introduced in upcoming .NET version, which is set to arrive in November as .NET 8.
// It provides optimized read-only collections for fast lookup and enumeration.
// These collections cannot be modified after they are created.
// They are ideal for scenarios where a collection is initialized once and used frequently throughout the application’s lifetime.


// Frozen namespace contains two classes and two structs:
// classes: 
// FrozenDictionary<TKey, TValue>
// FrozenSet<T>
// structs:
// FrozenDictionary<TKey,TValue>.Enumerator
// FrozenSet<T>.Enumerator


// Advantages:
// Faster lookup and enumeration performance due to using hash tables instead of arrays or linked lists.
// Reduced memory usage due to storing only one copy of each element instead of multiple copies for different views.
// Improved thread safety due to being immutable and not requiring synchronization or locking.

// Disadvantages:
// Higher construction cost due to hashing and sorting the elements during initialization.
// No support for dynamic resizing or modification of the collections after they are created.
// No support for custom equality comparers or hash code providers for the elements.