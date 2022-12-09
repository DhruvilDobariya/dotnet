namespace BasicFileOperations
{
    public class FileInfoClassProperties
    {
        public static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo(@"file");
            fileInfo.Create();

            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.LastWriteTime);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine(fileInfo.Directory);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.Attributes);

            fileInfo.Delete();

        }
    }
}
