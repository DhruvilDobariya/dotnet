namespace DateTimeDemo
{
    public class ConvertMethods
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToFileTime());
            Console.WriteLine(dt.ToLocalTime());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToOADate());
            Console.WriteLine(dt.ToUniversalTime());


        }
    }
}
