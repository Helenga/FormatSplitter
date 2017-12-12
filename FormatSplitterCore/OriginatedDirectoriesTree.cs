using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FormatSplitterCore
{
    public class OriginatedDirectoriesTree
    {
        private static Dictionary<string, List<string>> sortedByExtensionFiles;

        private static List<string> extensions;

        public IEnumerable<string> FormTree(string root)
        {
            extensions = new List<string>();
            sortedByExtensionFiles = new Dictionary<string, List<string>>();
            var files = selectFiles(root);
            foreach (var file in files)
            {
                var splittedPath = file.Split('.');
                var extension = splittedPath[splittedPath.Length-1];
                if (!extensions.Contains(extension))
                {
                    extensions.Add(extension);
                    List<string> fileWithExtension = new List<string>();
                    fileWithExtension.Add(file);
                    sortedByExtensionFiles.Add(extension, fileWithExtension);
                }
                else
                {
                    sortedByExtensionFiles[extension].Add(file);
                }
                    
            }
            return extensions;
        }

        public List<string> GetFilesWithExtension(string extension)
        {
            var filesWithExtension = sortedByExtensionFiles[extension];
            return filesWithExtension;
        }

        private IEnumerable<string> selectFiles(string root)
        {
            IEnumerable<string> files = Directory.GetFiles(root);
            return files;
        }
    }
}
