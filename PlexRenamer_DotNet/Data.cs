using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexRenamer_DotNet
{
    class Data
    {
        public List<string> OldFileNames { get; set; }
        public List<string> NewFileNames { get; set; }
        public string Path { get; set; }
        public string FileType { get; set; }
        public int NumOfFiles { get; set; }
        public string NameOfShow { get; set; }
        public int Season { get; set; }
        public string SubLang { get; set; }
        public bool NoPath = true;

        public void ClearData()
        {
            OldFileNames.Clear();
            NewFileNames.Clear();
            Path = "null";
            NoPath = true;
            FileType = "null";
            NumOfFiles = 0;
            NameOfShow = "Please enter show name";
            SubLang = "null";
            Season = 0;
        }
    }
}
