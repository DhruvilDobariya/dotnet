namespace DateTimeDemo
{
    public class AddMethods
    {
        public static void Main(string[] args)
        {
            //DateTime is immutable
            DateTime dt = new DateTime(2002, 1, 1, 1, 1, 1, 1, 1);
            Console.WriteLine(dt);

            Console.WriteLine(dt.AddYears(2));

            Console.WriteLine(dt.AddMonths(2));

            Console.WriteLine(dt.AddDays(2));

            Console.WriteLine(dt.AddHours(2));

            Console.WriteLine(dt.AddMinutes(2));

            Console.WriteLine(dt.AddSeconds(2));

            Console.WriteLine(dt.AddMilliseconds(2));

            Console.WriteLine(dt.AddMicroseconds(2));

            Console.WriteLine(dt.AddTicks(2));

            Console.WriteLine(dt.Add(new TimeSpan(2, 2, 2, 2, 2, 2)));

        }
    }
}
