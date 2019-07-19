using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plex_Renamer_DotNet_WPF
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
        public int StartingEp = 1;

        
        //<summary> Used to tell the program to clear the directory Bool or not </summary>
        public void ClearData(bool ClearDirectory)
        {
            if (ClearDirectory == false)
            {
                // no need to change path
                NoPath = false;
            }
            else
            {
                Path = "null";
                NoPath = true;
            }
            OldFileNames.Clear();
            NewFileNames.Clear();
            FileType = "null";
            NumOfFiles = 0;
            NameOfShow = "Please enter show name";
            SubLang = null;
            Season = 0;

        }
    }
}
