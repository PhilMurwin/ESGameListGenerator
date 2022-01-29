using ESGameListGenerator2.Models.EmuStation;

namespace ESGameListGenerator2.Utility
{
    public static class GameListHelper
    {
        public static GameList GetEmuStationGameList(string romFolder, string romExtension, bool preview = false)
        {
            var files = DirectoryScanner.FindFilesMatching(romFolder, romExtension);

            var games = files.Select(f => new Game
            {
                Name = Path.GetFileNameWithoutExtension(f.Name),
                Path = string.Format("./{0}", f.Name)
            }).ToList();

            if (preview)
            {
                games = games.Take(1).ToList();
            }

            var gameList = new GameList { Games = games };

            return gameList;
        }
    }
}
