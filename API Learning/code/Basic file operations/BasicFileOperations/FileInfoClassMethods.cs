namespace BasicFileOperations
{
    public class FileInfoClassMethods
    {
        public static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"file");

            fileInfo.Create();

            StreamWriter streamWriter = fileInfo.AppendText();
            streamWriter.WriteLine("Dhruvil Dobariya");
            streamWriter.Close();

            fileInfo.MoveTo(@"directory/sub directory");

            FileStream fileStream1 = fileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            fileStream1.Close();

            FileStream fileStream2 = fileInfo.OpenWrite();
            fileStream2.Close();

            FileStream fileStream3 = fileInfo.OpenRead();
            fileStream3.Close();

            fileInfo.Delete();


        }
    }
}
