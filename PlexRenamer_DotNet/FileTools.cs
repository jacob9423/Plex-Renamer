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

        public void TestFun()
        {
            GetFileList();
            FileData.FileType = GetExt(FileData.OldFileNames);
            DisplayListString(FileData.OldFileNames);
            FileData.NewFileNames = GenerateNewNames(FileData.OldFileNames, FileData.NumOfFiles);
            Console.WriteLine("New Names --------------------------------------------");
            DisplayListString(FileData.NewFileNames);
            RenameFiles();
            Console.ReadKey();
        }
        public void GetFileList()
        {
            FileData.NumOfFiles = Directory.GetFiles(FileData.Path).Count();
            FileData.OldFileNameString = Directory.GetFiles(FileData.Path);
            FileData.OldFileNames = FileData.OldFileNameString.ToList();
            FileData.OldFileNames = FileData.OldFileNames.OrderBy(n => n).ToList();
            FileData.NumOfFiles = FileData.OldFileNames.Count();
        }
        public string GetExt(List<string> FileNames)
        {
            return Path.GetExtension(FileNames[0]);
        }
        public void DisplayListString(List<string> ListToDisplay)
        {
            for (int i = 0; i < ListToDisplay.Count(); i++)
            {
                Console.WriteLine(ListToDisplay[i]);
            }
        }
        public List<string> GenerateNewNames(List<string> OldNames, int OldNameCount)
        {
            List<string> NewNames = new List<string>();
            string SeasonString = FileData.Season.ToString();
            int EpCount = 1;
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
