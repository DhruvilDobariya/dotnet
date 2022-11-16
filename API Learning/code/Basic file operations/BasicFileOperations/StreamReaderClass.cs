namespace BasicFileOperations
{
    public class StreamReaderClass
    {
        public static void Main(string[] args)
        {
            StreamReader steamReader = new StreamReader(@"names.txt");

            string line;
            while((line = steamReader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(steamReader.Peek());

            steamReader.Close();
        }
    }
}
