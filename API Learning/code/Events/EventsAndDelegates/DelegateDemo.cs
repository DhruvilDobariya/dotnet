namespace EventsAndDelegates
{
    public class DelegateDemo
    {
        public delegate int NumberChanger(int n);
        public static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        public static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine($"Value of Num: {GetNum()}");
            nc2(5);
            Console.WriteLine($"Value of Num: {GetNum()}");
        }
    }
}
