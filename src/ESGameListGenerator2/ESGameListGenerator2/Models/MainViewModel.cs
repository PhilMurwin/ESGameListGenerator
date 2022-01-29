using ESGameListGenerator2.Utility;

namespace ESGameListGenerator2.Models
{
    public class MainViewModel
    {
        public List<string> Extensions = new List<string>();

        public void UpdateExtensionList( string folderPath )
        {
            Extensions.Clear();
            Extensions = DirectoryScanner.GetFileExtensionsInDirectory(folderPath);
        }
    }
}
