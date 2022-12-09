namespace ConstructorDestructor
{
    public class ConstructorDestructor
    {
        public ConstructorDestructor()
        {
            Console.WriteLine("Defaulr constructor called.");
        }
        public ConstructorDestructor(string name)
        {
            Console.WriteLine($"Parameterized constructor called by : {name}");
        }
        ~ConstructorDestructor()
        {
            Console.WriteLine("Destructor called");
        }
    }
    public class ConstructorDestructorDemo
    {
        public static void Main(string[] args)
        {
            ConstructorDestructor constructorDestructor = new ConstructorDestructor();
            ConstructorDestructor constructorDestructor2 = new ConstructorDestructor("Dhruvil");
        }
    }
}
