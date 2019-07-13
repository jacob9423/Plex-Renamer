using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlexRenamer_DotNet
{
    class FileTools
    {
        public Data FileData = new Data();

      //<summary> Gets the list of files in a directory. and puts them in there internal varibles </summary>
      // For everything to work I need the number of files in that directory, The file paths, the ext, and then
      // order them starting from episode 0
      // Arguments: None
      // Returns:   None
        public void GetFileList()
        {
            FileData.NumOfFiles = Directory.GetFiles(FileData.Path).Count();
            FileData.OldFileNames = Directory.GetFiles(FileData.Path).ToList();
            FileData.OldFileNames = FileData.OldFileNames.OrderBy(n => n).ToList();
        }

        //<summary> gets the file ext form the first postion of a list of file paths </summary>
        // Arguments: 
        //            FileNames - A list of file names
        // Returns:   None
        public string GetExt(List<string> FileNames)
        {
            return Path.GetExtension(FileNames[0]);
        }

        //<summary> generates names for the files based on the number of files </summary>
        //Arguments: 
        //           List: OldNames - a list of file paths
        //           int:  OldNameCount - the number of files in that list
        //           int:  StartingEp - The number to start the episode count
        //Returns: 
        //           List: the list of new file names 
        public List<string> GenerateNewNames(List<string> OldNames, int OldNameCount,int StartingEp)
        {
            List<string> NewNames = new List<string>();
            string SeasonString = FileData.Season.ToString();
            int EpCount = StartingEp;

            if (FileData.Season < 10)
            {
                SeasonString = "0" + FileData.Season;
            }

            for (int i = 0; i < OldNameCount; i++)
            {
                if (EpCount < 10)
                {
                    NewNames.Add(FileData.Path + "\\" + FileData.NameOfShow + " - " + "s" + SeasonString + "e" + "0" + EpCount + FileData.FileType);
                }
                else
                {
                    NewNames.Add(FileData.Path + "\\" + FileData.NameOfShow + " - " + "s" + SeasonString + "e" + EpCount + FileData.FileType);
                }
                EpCount++;
            }

            return NewNames;              
        }

        //<summary> generates names for the files based on the number of files (for subtitle files) </summary>
        //Arguments: 
        //           List: OldNames - a list of file paths
        //           int:  OldNameCount - the number of files in that list
        //           int:  StartingEp - The number to start the episode count
        //Returns: 
        //           List: the list of new file names
        public List<string> GenerateNewNamesForSubs(List<string> OldNames, int OldNameCount, int StartingEp)
        {
            List<string> NewNames = new List<string>();
            string SeasonString = FileData.Season.ToString();
            int EpCount = StartingEp;

            if (String.IsNullOrEmpty(FileData.SubLang))
            {
                FileData.SubLang = "eng";
            }

            if (FileData.Season < 10)
            {
                SeasonString = "0" + FileData.Season;
            }

            for (int i = 0; i < OldNameCount; i++)
            {
                if (EpCount < 10)
                {
                    NewNames.Add(FileData.Path + "\\" + FileData.NameOfShow + " - " + "s" + SeasonString + "e" + "0" + EpCount + "." + FileData.SubLang + FileData.FileType);
                }
                else
                {
                    NewNames.Add(FileData.Path + "\\" + FileData.NameOfShow + " - " + "s" + SeasonString + "e" + EpCount + "." + FileData.SubLang + FileData.FileType);
                }
                EpCount++;
            }

            return NewNames;
        }
        // <summary> Renames the files in the directory </summary>
        // Arguments: None
        // Returns: None
        public void RenameFiles()
        {
            for (int i = 0; i < FileData.NumOfFiles; i++)
            {
                System.IO.File.Move(FileData.OldFileNames[i], FileData.NewFileNames[i]);
            }
        }
    }
}
