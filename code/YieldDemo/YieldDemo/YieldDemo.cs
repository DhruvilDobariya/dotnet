namespace YieldDemo
{
    public class YieldDemo
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya" },
            new Student() {Id = 2, Name = "Dhaval Dobariya" },
            new Student() {Id = 3, Name = "Bhargav Vachhani" },
            new Student() {Id = 4, Name = "Jenil Vasoya" }
        };
        public static void Main(string[] args)
        {
            List<string> students = GetStudent().ToList();
            students.ForEach(x => Console.WriteLine(x));
        }
        
        public static IEnumerable<string> GetStudent()
        {
            foreach (Student student in _students)
            {
                if (student.Id == 3)
                {
                    yield break;
                }
                yield return student.Name;
            }
        }
    }
}
