using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace SpanLearn;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<SpanLearning>();
    }
}

[MemoryDiagnoser]
public class SpanLearning
{
    private readonly string _date = "04 04 2002";

    [Benchmark]
    public DateTime GetDateUsingString()
    {
        var day = _date.Substring(0, 2);
        var month = _date.Substring(3, 2);
        var year = _date.Substring(6);
        return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
    }

    [Benchmark]
    public DateTime GetDateUsingSpan()
    {
        ReadOnlySpan<char> dateSpan = _date;
        var day = dateSpan.Slice(0, 2);
        var month = dateSpan.Slice(3, 2);
        var year = dateSpan.Slice(6);
        return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
        // If we want to process string after return then we should also return ReadonlySpan<char> directly and manipulate it.
    }
    
    // Span is faster then other because, It's use use stack as a memory where other is use heap.
    // In case of string when we initialize "04 04 2002" it create one instance in heap.
    // Now because of string is immutable so when we use Substring at that time for each substring we it allocate new memory in heap.
    // Ex: "04 04 2002" for one allocation in heap
    // Substring(0, 2) = "04" another allocation of memory in heap
    // Substring(3, 2) = "04" another allocation of memory in heap
    // Substring(6) = "2002" another allocation of memory in heap
    
    // Now when we use Span at that time it create a stack for memory.
    // Because of span in ref struct so it store pointer of any object.
    // So when we use slice method it working with pointer an that pointer store in stack.
    // Ex: We have ReadOnlySpan<Char> from "04 04 2002" string
    // In stack at first position it stored address of "04 04 2002"
    // Then when we use Slice(0, 2) it store address of "04 04 2002" with starting index or we can say offset which is 0 in our case.
    // Then it will stored length at third which is 2 in our case.
    // Using second an third index of stack span point "04" (day) of "04 04 2002";
    // Same as when we use Slice(3, 2) it store address of "04 04 2002" with starting index or we can say offset which is 3 in our case.
    // Then it will stored length at third which is 2 in our case.
    // Using second an third index of stack span point "04" (month) of "04 04 2002";
    // Same as when we use Slice(6) it store address of "04 04 2002" with starting index or we can say offset which is 6 in our case.
    // Then it will stored length at third which is max length of string in our case.
    // Using second an third index of stack span point "2002" (year) of "04 04 2002";
    // Because of this pattern we get better performance with less memory allocation. 
}