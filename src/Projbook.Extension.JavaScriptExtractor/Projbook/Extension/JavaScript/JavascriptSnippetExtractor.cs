using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projbook.Extension.Model;
using Projbook.Extension.Spi;

namespace Projbook.Extension.JavaScriptExtractor
{
    /// <summary>
    /// Extractor in charge of browsing source directories. load javascript file content and extract requested member.
    /// </summary>
    [Syntax(name: "javascript")]
    public class JavascriptSnippetExtractor : DefaultSnippetExtractor
    {   
        public Snippet Extract(FileSystemInfoBase fileSystemInfo, string pattern)
        {
                return base.Extract(fileSystemInfo, pattern);
        }
    }
}
