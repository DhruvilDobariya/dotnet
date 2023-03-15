using Spectre.Console;

namespace SpectreLearn
{
    public class Program
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
            Table table = new Table();
            table.AddColumns(new string[] { "Id", "Name" });

            _students.ForEach(x => table.AddRow(x.Id.ToString(), x.Name));

            AnsiConsole.Write(table);
        }
    }
}
