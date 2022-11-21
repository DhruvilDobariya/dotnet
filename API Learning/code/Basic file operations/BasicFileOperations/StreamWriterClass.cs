namespace BasicFileOperations
{
    public class StreamWriterClass
    {
        public static void Main(string[] args)
        {
            string[] names = new string[] { "Dhruvil", "Dhaval", "Bhargav", "Jenil" };

            StreamWriter streamWriter = new StreamWriter(@"names.txt");

            foreach (string name in names)
            {
                streamWriter.WriteLine(name);
            }
            streamWriter.Write("I am .Net Developer");

            streamWriter.Flush();
            streamWriter.Close();


            StreamReader streamReader = new StreamReader(@"names.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            streamReader.Close();

        }
    }
}
