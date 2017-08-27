﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ESGameListGenerator
{
    public static class Extensions
    {
        public static IEnumerable<FileInfo> GetFilesByExtensions( this DirectoryInfo dir, params string[] extensions )
        {
            if ( extensions == null )
            {
                throw new ArgumentNullException( "extensions" );
            }

            IEnumerable<FileInfo> files = dir.EnumerateFiles();
            var fileInfoList = files.Where( f => extensions.Contains( f.Extension ) );

            return fileInfoList;
        }
    }
}
