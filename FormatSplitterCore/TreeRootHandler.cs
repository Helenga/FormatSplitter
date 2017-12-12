using System;
using System.Collections.Generic;
using System.Text;

namespace FormatSplitterCore
{
    public class TreeRootHandler
    {
        private const string _defaultRoot = "C://";

        public string SpecifiedRoot { get; set; }

        public string GetRoot()
        {
            if (SpecifiedRoot != null)
                return SpecifiedRoot;
            else
                return _defaultRoot;
        }
    }
}
