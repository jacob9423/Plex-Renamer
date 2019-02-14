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
            DirectforyFinder.ShowDialog();
            app.FileData.Path = DirectforyFinder.SelectedPath;
            lblPath.Text = app.FileData.Path;
            app.FileData.NoPath = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            listData.Clear();

            if (app.FileData.NoPath)
            {
                DirectforyFinder.ShowDialog();
                app.FileData.Path = DirectforyFinder.SelectedPath;
                app.FileData.NoPath = false;
            }

            app.FileData.NameOfShow = txtShow.Text;
            app.FileData.Season = Convert.ToInt32(numupSeason.Value);
            app.GetFileList();
            app.GetExt(app.FileData.OldFileNames);

            for (int i = 0; i < app.FileData.OldFileNames.Count; i++)
            {
                listData.Items.Add(app.FileData.OldFileNames[i].ToString());
            }

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if(app.FileData.NoPath)
            {
                DirectforyFinder.ShowDialog();
                app.FileData.Path = DirectforyFinder.SelectedPath;
                app.FileData.NoPath = false;
            }

            app.FileData.NameOfShow = txtShow.Text;
            app.FileData.Season = Convert.ToInt32(numupSeason.Value);
            app.GetFileList();
            app.FileData.FileType = app.GetExt(app.FileData.OldFileNames);

            if (lblSubtitles.Visible)
            {
                app.FileData.NewFileNames = app.GenerateNewNamesForSubs(app.FileData.OldFileNames, app.FileData.NumOfFiles);
            }
            else
            {
                app.FileData.NewFileNames = app.GenerateNewNames(app.FileData.OldFileNames, app.FileData.NumOfFiles);
            }
         
            MessageBox.Show("You are about to rename files in " + app.FileData.Path);
            app.RenameFiles();
            MessageBox.Show("done");
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
    }
}
