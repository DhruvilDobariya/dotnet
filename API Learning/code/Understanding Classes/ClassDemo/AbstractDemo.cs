namespace ClassDemo
{
    public class AbstractDemo
    {
        public static void Main(string[] args)
        {
            AbstarctImplement ai = new AbstarctImplement();
            ai.SetProparties("Dhruvil Dobariya", "Microsoft");
            ai.Display();
        }
    }
    public abstract class AbstractClass
    {
        abstract public string Name { get; set; }
        public string CompanyName { get; set; } = string.Empty;

        public void Display()
        {
            Console.WriteLine($"{Name} is working at {CompanyName}.");
        }
        abstract public void SetProparties(string Name, string CompanyName);
    }
    public class AbstarctImplement : AbstractClass
    {
        public override string Name { get; set; } = string.Empty;

        public override void SetProparties(string Name, string CompanyName)
        {
            this.Name = Name;
            this.CompanyName = CompanyName;
        }
    }
}
