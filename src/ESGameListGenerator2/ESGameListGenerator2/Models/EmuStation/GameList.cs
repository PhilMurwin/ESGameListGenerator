using ESGameListGenerator2.Utility;
using System.Xml.Serialization;

namespace ESGameListGenerator2.Models.EmuStation
{
    [XmlRoot(ElementName = "gameList")]
    public class GameList
    {
        [XmlElement(ElementName = "game")]
        public List<Game> Games { get; set; }

        public void SetGameImages( string imgDirectory, bool useSubFolder = false, string subFolderName = null )
        {
            var imgDir = useSubFolder ? Path.Combine(imgDirectory, subFolderName) : imgDirectory;
            var piSubDir = useSubFolder ? subFolderName : "";

            var imageFiles = DirectoryScanner.FindImageFiles(imgDir);

            foreach (var imgFile in imageFiles)
            {
                var game = Games.FirstOrDefault(g => g.Name == Path.GetFileNameWithoutExtension(imgFile.Name));

                if (game != null)
                {
                    game.Image = string.Format("./{0}/{1}", piSubDir, imgFile.Name);
                }
            }
        }
    }
}
