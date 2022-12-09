using ExternalClassLibrary;
using InternalClassLibrary;

namespace CreatingAndAddingReferenceToAssemblies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InternalClassLibraryDemo iCLD = new InternalClassLibraryDemo();
            iCLD.ShowMessage();

            ExternalClassLibraryDemo eCLD = new ExternalClassLibraryDemo();
            eCLD.ShowMessage();
        }
    }
}
