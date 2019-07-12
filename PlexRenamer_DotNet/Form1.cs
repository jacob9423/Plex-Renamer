using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlexRenamer_DotNet
{
    public partial class Form1 : Form
    {
        FileTools app = new FileTools();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            getDirectory();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblProgramDone.Text = "";

            ClearDataGrid();

            CheckIfNoPath();

            GetShowData();

            DisplayData(app.FileData.OldFileNames);

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            lblProgramDone.Text = "";

            app.FileData.StartingEp = (int)numStartingCount.Value;

            ClearDataGrid();

            CheckIfNoPath();

            GetShowData();

            

            if (lblSubtitles.Visible)
            {
                app.FileData.NewFileNames = app.GenerateNewNamesForSubs(app.FileData.OldFileNames, app.FileData.NumOfFiles, (int)app.FileData.StartingEp);
            }
            else
            {
                app.FileData.NewFileNames = app.GenerateNewNames(app.FileData.OldFileNames, app.FileData.NumOfFiles,(int)app.FileData.StartingEp);
            }

            string message = "You are about to rename files in " + app.FileData.Path;
            string title = "Are you Sure?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                app.RenameFiles();
                lblProgramDone.Text = "Done!";
                app.GetFileList();
                DisplayData(app.FileData.OldFileNames);
            }
            
            app.FileData.ClearData();
        }

        private void chkSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            if(lblSubtitles.Visible == false)
            {
                lblSubtitles.Visible = true;
                txtSubtitles.Visible = true;
            }
            else
            {
                lblSubtitles.Visible = false;
                txtSubtitles.Visible = false;
            }
        }

        private void GetShowData()
        {
            app.FileData.NameOfShow = txtShow.Text;
            app.FileData.Season = Convert.ToInt32(numupSeason.Value);
            app.GetFileList();
            
            // to fix a bug where if the user picks a folder with only folders in it the program will error out.
            try
            {
                app.FileData.FileType = app.GetExt(app.FileData.OldFileNames);
            }
            catch
            {
               MessageBox.Show("Are you trying to rename a Folder without video files in it? Please select another folder");
               
               getDirectory();
            }
        
            
        }
        
        private void DisplayData(List<string> listToDisplay)
        {
            foreach (var list in listToDisplay)
            {
                dgvData.Rows.Add(list);
            }
        }
        private void ClearDataGrid()
        {
            dgvData.Rows.Clear();
            dgvData.Refresh();
        }
        
        private void CheckIfNoPath()
        {
            if (app.FileData.NoPath)
            {
               getDirectory();
            }
        }

        private void getDirectory()
        {
            DirectforyFinder.ShowDialog();
            app.FileData.Path = DirectforyFinder.SelectedPath;
            lblPath.Text = app.FileData.Path;
            app.FileData.NoPath = false;
        }


        private void chkDifEp_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDifEp.Checked == false)
            {
                lblStartCount.Visible = false;
                numStartingCount.Visible = false;
                numStartingCount.Value = 1;
            }
            else
            {
                lblStartCount.Visible = true;
                numStartingCount.Visible = true;
            }
        }
       
    }
}
