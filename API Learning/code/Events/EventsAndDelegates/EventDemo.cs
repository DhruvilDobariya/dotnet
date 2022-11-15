namespace EventsAndDelegates
{
    public class EventDemo
    {
        public delegate string MyDel(string str);
        public event MyDel MyEvent;
        public EventDemo()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        public static void Main(string[] args)
        {
            EventDemo eventDemo = new EventDemo();
            string result = eventDemo.MyEvent("Dhruvil");
            Console.WriteLine(result);
        }
    }
}
