using BookAPI.Domain.Models;

namespace TypeLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine(user.GetType().ToString().Split(".")[3]);
            Console.WriteLine(typeof(User).ToString().Split(".")[3]);
        }
    }
}
