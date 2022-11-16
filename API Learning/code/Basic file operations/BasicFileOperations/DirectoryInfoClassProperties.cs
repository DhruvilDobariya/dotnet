namespace BasicFileOperations
{
    public class DirectoryInfoClassProperties
    {
        public static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"directory");

            directoryInfo.Create();

            Console.WriteLine(directoryInfo.FullName);
            FileAttributes fileAttributes = directoryInfo.Attributes;
            Console.WriteLine(fileAttributes.ToString());
            Console.WriteLine(directoryInfo.CreationTime);
            Console.WriteLine(directoryInfo.LastAccessTime);
            Console.WriteLine(directoryInfo.Exists);
            Console.WriteLine(directoryInfo.Extension);
            Console.WriteLine(directoryInfo.Name);

            directoryInfo.Delete();
        }
    }
}
