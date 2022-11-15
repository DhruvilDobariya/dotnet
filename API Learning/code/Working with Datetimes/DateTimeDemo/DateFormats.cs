namespace DateTimeDemo
{
    public class DateFormats
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToString("dd")); // date
            Console.WriteLine(dt.ToString("MM")); // Month
            Console.WriteLine(dt.ToString("yy")); // Year in two digite
            Console.WriteLine(dt.ToString("HH")); // Hour in 24
            Console.WriteLine(dt.ToString("hh")); // Hour in 12
            Console.WriteLine(dt.ToString("tt")); // AM and PM
            Console.WriteLine(dt.ToString("mm")); // Minute
            Console.WriteLine(dt.ToString("ss")); // Second
            Console.WriteLine(dt.ToString("dddd")); // Full name of day
            Console.WriteLine(dt.ToString("ddd")); // Sort name of day
            Console.WriteLine(dt.ToString("MMM")); // Sort name of month
            Console.WriteLine(dt.ToString("MMMM")); // Full name of month
            Console.WriteLine(dt.ToString("yyyy")); // Full length year
            Console.WriteLine(dt.ToString("dd/MM/yy"));
            Console.WriteLine(dt.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine(dt.ToString("ddd, dd MMM yyy HH:mm:ss 'GMT'"));
        }
    }
}
