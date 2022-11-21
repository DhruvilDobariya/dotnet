namespace BasicFileOperations
{
    public class FileClass
    {
        public static void Main(string[] args)
        {
            string path = "text.txt";
            FileStream file = File.Create(path);
            file.Close();

            FileStream file2 = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            file2.Close();

            FileStream file3 = File.OpenRead(path);
            file3.Close();

            FileStream file4 = File.OpenWrite(path);
            file4.Close();

            // In Copy and Move, if file not exist then create automaticlly.
            File.Copy(path, "./directory/CopyText.txt"); // Just Copy the file, Sorce file is stand at thire location.

            File.Move(path, "./directory/MoveText.txt"); // It move whole file, Source file is cut and past at new location and new name

            //File.Delete("./directory/CopyText.txt");
            //File.Delete("./directory/MoveText.txt");

            if (File.Exists("./directory/MoveText.txt"))
            {
                File.Delete("./directory/MoveText.txt");
            }


        }
    }
}
