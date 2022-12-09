namespace BasicFileOperations
{
    public class DirectoryInfoClassMethods
    {
        public static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"directory");

            directoryInfo.Create();
            directoryInfo.CreateSubdirectory("sub directory");

            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo d in directories)
            {
                Console.WriteLine(d.Name);
            }

            FileInfo fileInfo = new FileInfo(@"directory/file");
            fileInfo.Create();
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            foreach (FileInfo f in fileInfos)
            {
                Console.WriteLine(f.Name);
            }

            directoryInfo.Delete();
        }
    }
}
