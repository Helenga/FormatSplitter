using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FormatSplitterCore
{
    public class SystemDirectoriesTree
    {
        public IEnumerable<string> TraverseTree(string root)
        {
            IEnumerable<string> subdirs = Directory.GetDirectories(root);
            return subdirs;
        }
    }
}
