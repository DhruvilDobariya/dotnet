namespace DateTimeDemo
{
    public class Properties
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);
            Console.WriteLine(dt.Millisecond);
            Console.WriteLine(dt.Microsecond);
            Console.WriteLine(dt.Nanosecond);

            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.Day);

            Console.WriteLine(dt.Kind);
            Console.WriteLine(dt.Ticks);

            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Today);
        }
    }
}
