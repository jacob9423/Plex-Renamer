using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using WinForm = System.Windows.Forms;

namespace Plex_Renamer_DotNet_WPF
{
    //  liViewData.ItemsSource = whatever how to use the listview
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileTools app = new FileTools();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnChooseDirectory_Click(object sender, RoutedEventArgs e)
        {
            GetDirectory();
            CheckDirectory();
        }
   
        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            CheckDirectory();
        }
        private void BtnRename_Click(object sender, RoutedEventArgs e)
        {
            // to check if ther user is running this program a secound time. 
            //If so they could have already picked a directory and would like to use the one they already selected
            if (app.FileData.NumOfFiles != 0 && app.FileData.NoPath == false)
            {
                app.FileData.ClearData(false);
            }
            else if(app.FileData.NumOfFiles != 0)
            {
                app.FileData.ClearData(true);
            }
            
            app.FileData.StartingEp = (int)numStartingCount.Value;

            CheckIfNoPath();

            GetShowData();


            if (lblSubtitles.IsVisible)
            {
                app.FileData.NewFileNames = app.GenerateNewNamesForSubs(app.FileData.OldFileNames, app.FileData.NumOfFiles, (int)app.FileData.StartingEp);
            }
            else
            {
                app.FileData.NewFileNames = app.GenerateNewNames(app.FileData.OldFileNames, app.FileData.NumOfFiles, (int)app.FileData.StartingEp);
            }

            string message = "You are about to rename files in " + app.FileData.Path;
            string title = "Are you Sure?";

            WinForm.MessageBoxButtons buttons = WinForm.MessageBoxButtons.YesNo;
            WinForm.DialogResult result = WinForm.MessageBox.Show(message, title, buttons);

            if (result == WinForm.DialogResult.Yes)
            {
                app.RenameFiles();
                app.GetFileList();
                DisplayData(app.FileData.OldFileNames);
                app.FileData.NoPath = true;
            }
          
        }

        private void chkSubtitles_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkSubtitles.IsChecked == true)
            {
                lblSubtitles.Visibility = Visibility.Visible;
                txtSubtitles.Visibility = Visibility.Visible;
            }
            else
            {
                lblSubtitles.Visibility = Visibility.Hidden;
                txtSubtitles.Visibility = Visibility.Hidden;
            }
        }
        private void chkDifEp_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkDifEp.IsChecked == false)
            {
                numStartingCount.Visibility = Visibility.Hidden;
                numStartingCount.Value = 1;
            }
            else
            {
                numStartingCount.Visibility = Visibility.Visible;
            }
        }
        //Functions --------------------------------------------------------------------------------------------------------------------------------

        //<summary> Gets the inital show data from user input</summary>
        // Gets the userinput from the textbox season number box and puts them into varibles to use later.
        // Also gets the list of files from the directory that was picked by the  user and checks to make sure there is files in that directory and not just folders.
        // it does this by just checking to see if it gets an exception.
        // Arguments: None
        // Returns:   None
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
                System.Windows.MessageBox.Show("Are you trying to rename a Folder without video files in it? Please select another folder");

                GetDirectory();
            }

        }
        //<summary> Gets the diretory the user wants to rename</summary>
        // Arguments: None
        // Returns:   None
        private void GetDirectory()
        {
            var dialog = new WinForm.FolderBrowserDialog();
            dialog.ShowDialog();
            app.FileData.Path = dialog.SelectedPath;
            txtPath.Text = app.FileData.Path;
            app.FileData.NoPath = false;
        }
        //<summary> Used to check if a directory has been selected and if not. make the user select one</summary>
        // Arguments: None
        // Returns:   None
        private void CheckIfNoPath()
        {
            if (app.FileData.NoPath == true)
            {
                GetDirectory();
            }
        }
        //<summary> Used to display data</summary>
        // Arguments: List<string> listToDisplay
        // Returns:   None
        private void DisplayData(List<string> listToDisplay)
        {
            liViewData.ItemsSource = listToDisplay;
        }

        //<summary> Used to check directory file order </summary>
        // Arguments: None
        // Returns:   None
        private void CheckDirectory()
        {
            CheckIfNoPath();

            GetShowData();

            DisplayData(app.FileData.OldFileNames);
        }
        
    }
}
