using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace NostalG
{
    public static class Helpers
    {
        public static int GetTotalFolders(string path)
        {
            return Directory.EnumerateDirectories(path).Count();
        }

        public static string[] GetFoldersNames(string path)
        {
            return Directory.GetDirectories(path)
                .Select(Path.GetFileName)
                .ToArray();
        }

        public static int GetTotalFiles(string path)
        {
            return Directory.GetFiles(path).Length;
        }

    }
}
