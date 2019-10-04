using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSFolderCleanup.Extensions;
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
                List<string> folders = new List<string>();
                FileSystem.EnumFiles(e.Result, "*", directoryFound: (dir) =>
                {
                    if (dir.Name.Equals("packages") || dir.FullName.ContainsAny("bin\\Debug", "bin\\Release", "obj\\Debug", "obj\\Release"))
                    {
                        if (DateTime.Now.Subtract(dir.LastWriteTimeUtc).TotalDays > 360)
                        {
                            Debug.WriteLine(dir.FullName);
                            folders.Add(dir.FullName);
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

        }
    }
}
