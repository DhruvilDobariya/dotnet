namespace DateTimeDemo
{
    public class OtherMethods
    {
        public static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime birthDate = new DateTime(2002, 4, 4);

            Console.WriteLine(DateTime.Compare(birthDate, dt));
            Console.WriteLine(dt.CompareTo(birthDate));

            Console.WriteLine(DateTime.DaysInMonth(dt.Year, dt.Month));
            Console.WriteLine(dt.Equals(birthDate));

            Console.WriteLine(DateTime.IsLeapYear(birthDate.Year));


        }
    }
}
