using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ESGameListGenerator
{
    public static class DirectoryScanner
    {
        public static List<FileInfo> FindFilesMatching( string dirPath, string pattern)
        {
            var files = new List<FileInfo>();

            if (!Directory.Exists(dirPath))
            {
                throw new ArgumentException( "Directory Path does not exist!" );
            }

            var dirInfo = new DirectoryInfo( dirPath );
            files = dirInfo.GetFiles( "*" + pattern ).ToList();

            return files;
        }

        public static List<string> GetFileExtensionsInDirectory( string dirPath )
        {
            var files = new List<string>();

            if ( !Directory.Exists( dirPath ) )
            {
                throw new ArgumentException( "Directory Path does not exist!" );
            }

            var dirInfo = new DirectoryInfo( dirPath );
            files = dirInfo.GetFiles().Select( f => f.Extension ).Distinct().ToList();

            return files;
        }

        public static List<FileInfo> FindImageFiles( string dirPath )
        {
            var imgFiles = new List<FileInfo>();

            var dirInfo = new DirectoryInfo( dirPath );
            imgFiles = dirInfo.GetFilesByExtensions( ".bmp", ".jpg", ".png" ).ToList();

            return imgFiles;
        }
    }
}
