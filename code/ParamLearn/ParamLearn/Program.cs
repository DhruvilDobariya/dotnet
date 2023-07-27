namespace ParamLearn;
public class Program
{
    public static void Main(string[] args)
    {
        ParamLearn("Dhruvil", "Dobariya");
    }
    public static void ParamLearn(params string[] a)
    {
        foreach (var x in a)
        {
            Console.WriteLine(x);
        }
    }
}