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

      
        public void GetFileList()
        {
            FileData.NumOfFiles = Directory.GetFiles(FileData.Path).Count();
            FileData.OldFileNames = Directory.GetFiles(FileData.Path).ToList();
            FileData.OldFileNames = FileData.OldFileNames.OrderBy(n => n).ToList();
            FileData.NumOfFiles = FileData.OldFileNames.Count();
        }

        public string GetExt(List<string> FileNames)
        {
            return Path.GetExtension(FileNames[0]);
        }
        
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

        public void RenameFiles()
        {
            for (int i = 0; i < FileData.NumOfFiles; i++)
            {
                System.IO.File.Move(FileData.OldFileNames[i], FileData.NewFileNames[i]);
            }

            Console.WriteLine("Done");
        }
    }
}
