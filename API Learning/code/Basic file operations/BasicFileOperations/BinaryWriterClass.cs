namespace BasicFileOperations
{
    public class BinaryWriterClass
    {
        public static void Main(string[] args)
        {
            BinaryWriter binaryWriter;

            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy";

            try
            {
                binaryWriter = new BinaryWriter(new FileStream("mydata", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }

            try
            {
                binaryWriter.Write(i);
                binaryWriter.Write(d);
                binaryWriter.Write(b);
                binaryWriter.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            binaryWriter.Close();
        }
    }
}
