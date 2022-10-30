namespace ClassDemo
{
    public class PartialDemo
    {
        public static void Main(string[] args)
        {
            PartialClass pc = new PartialClass();
            pc.SetProparties("Dhruvil Dobariya", "Microsoft");
            pc.Display();
        }
    }
    public partial class PartialClass
    {
        public string Name { get; set; } = string.Empty;

        public void SetProparties(string Name, string CompanyName)
        {
            this.Name = Name;
            this.CompanyName = CompanyName;
        }
    }
    public partial class PartialClass
    {
        public string CompanyName { get; set; } = string.Empty;

        public void Display()
        {
            Console.WriteLine($"{Name} is working at {CompanyName}.");
        }
    }
}
