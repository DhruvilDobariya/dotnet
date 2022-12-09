namespace ClassDemo
{
    public class StaticDemo
    {
        public static void Main(string[] args)
        {
            StaticClass.SetProparties("Dhruvil Dobariya", "Microsoft");
            Console.WriteLine($"{StaticClass.Name} is working at {StaticClass.CompanyName}.");
        }

    }
    public static class StaticClass
    {
        public static string Name { get; set; } = string.Empty;
        public static string CompanyName { get; set; } = string.Empty;

        public static void SetProparties(string Name, string CompanyName)
        {
            StaticClass.Name = Name;
            StaticClass.CompanyName = CompanyName;
        }

    }
}
