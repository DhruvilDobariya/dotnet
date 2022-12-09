namespace EventsAndDelegates
{
    public class EventDemo
    {
        public delegate string MyDel(string str);
        public event MyDel MyEvent;
        //public EventDemo()
        //{
        //    this.MyEvent += new MyDel(this.WelcomeUser);
        //}
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        public string ValidateUser(string username)
        {
            if (username.Equals("Dhruvil"))
            {
                return "Valid User";
            }
            return "Invalid User";
        }
        public static void Main(string[] args)
        {
            EventDemo eventDemo = new EventDemo();
            eventDemo.MyEvent += new MyDel(eventDemo.ValidateUser);

            Console.Write("Enter a username : ");
            string username = Console.ReadLine();

            if(eventDemo.MyEvent(username).Equals("Valid User"))
            {
                eventDemo.MyEvent += new MyDel(eventDemo.WelcomeUser);
                string result = eventDemo.MyEvent(username);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid User");
            }
            
        }
    }
}
