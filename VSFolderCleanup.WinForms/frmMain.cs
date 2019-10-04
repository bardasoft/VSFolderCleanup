using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VSFolderCleanup.Extensions;
using VSFolderCleanup.Models;
using WinForms.Library;
using WinForms.Library.Controls;

namespace VSFolderCleanup
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void builderTextBox1_BuilderClicked(object sender, BuilderEventArgs e)
        {
            if (builderTextBox1.SelectFolder(e))
            {
                List<FolderItem> folders = new List<FolderItem>();
                FileSystem.EnumFiles(e.Result, "*", directoryFound: (dir) =>
                {
                    if (dir.Name.Equals("packages") || dir.FullName.ContainsAny("bin\\Debug", "bin\\Release", "obj\\Debug", "obj\\Release"))
                    {
                        if (DateTime.Now.Subtract(dir.LastWriteTimeUtc).TotalDays > 360)
                        {                            
                            folders.Add(new FolderItem() 
                            { 
                                FullPath = dir.FullName, 
                                DisplayPath = dir.FullName.Substring(e.Result.Length + 1) 
                            });
                        }
                        return EnumFileResult.NextFolder;
                    }                    

                    return EnumFileResult.Continue;
                });

                foreach (var item in folders) lbFolders.Items.Add(item);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbFolders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var item = lbFolders.SelectedItem as FolderItem;
                if (item != null)
                {
                    FileSystem.RevealInExplorer(item.FullPath);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lbFolders.Items)
                {
                    var folderItem = item as FolderItem;
                    if (folderItem != null)
                    {
                        try
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(folderItem.FullPath, Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents);
                        }
                        catch (Exception exc)
                        {
                            if (MessageBox.Show($"Couldn't delete {folderItem.FullPath}: {exc.Message}", "Delete Error", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
