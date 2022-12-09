namespace EnumerationDemo
{
    public enum Day
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class EnumDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Day.Sunday);
            Console.WriteLine((int)Day.Sunday);
        }
    }
}
