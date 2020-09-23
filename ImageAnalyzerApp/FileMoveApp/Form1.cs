using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMoveApp
{
    public partial class FileMoveForm : Form
    {
        // Private variables
        private string szSourDirectoryPath = string.Empty;
        private string szDestDirectoryPath = string.Empty;

        public FileMoveForm()
        {
            InitializeComponent();
        }

        private void FileMoveForm_Load(object sender, EventArgs e)
        {
            InitData_SourDirectoryPath();
            InitData_DestDirectoryPath();
            RefreshUI_SourDirectoryPath();
            RefreshUI_DestDirectoryPath();
        }

        private void buttonSour_Click(object sender, EventArgs e)
        {
            folderBrowserDialogForMove.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            var result = folderBrowserDialogForMove.ShowDialog();
            if (result != DialogResult.OK)
                return;

            if (Directory.Exists(folderBrowserDialogForMove.SelectedPath) == false)
                return;

            // Refresh Data
            szSourDirectoryPath = folderBrowserDialogForMove.SelectedPath;

            // Refresh UI
            RefreshUI_SourDirectoryPath();
        }

        private void buttonDest_Click(object sender, EventArgs e)
        {
            folderBrowserDialogForMove.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            var result = folderBrowserDialogForMove.ShowDialog();
            if (result != DialogResult.OK)
                return;

            if (Directory.Exists(folderBrowserDialogForMove.SelectedPath) == false)
                return;

            // Refresh Data
            szDestDirectoryPath = folderBrowserDialogForMove.SelectedPath;

            // Refresh UI
            RefreshUI_DestDirectoryPath();
        }


        private Dictionary<string, string> dicMoveTarget = new Dictionary<string, string>();

        private List<TargetFileInfo> listTargetFile = new List<TargetFileInfo>();

        struct TargetFileInfo
        {
            public string Name;
            public string Path;
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(szSourDirectoryPath) ||
                string.IsNullOrEmpty(szDestDirectoryPath))
            {
                MessageBox.Show("Path Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBoxNames.Text))
            {
                MessageBox.Show("Name Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var paths = Directory.GetFiles(szSourDirectoryPath, "*.jpg");
            if (null == paths)
            {
                MessageBox.Show("Target File Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var NamesOrigin = textBoxNames.Text;
            var NamesConvert = NamesOrigin.Replace(" ", string.Empty);
            NamesConvert = NamesConvert.Replace("\r", string.Empty);
            var NamesArray = NamesConvert.Split('\n');
            dicMoveTarget.Clear();
            foreach (var Name in NamesArray)
            {
                if (string.IsNullOrEmpty(Name) == false)
                {
                    if (dicMoveTarget.ContainsKey(Name) == false)
                        dicMoveTarget.Add(Name, Name);
                }
            }

            if (dicMoveTarget.Count == 0)
            {
                MessageBox.Show("Copy Target Names Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listTargetFile.Clear();
            for (int i = 0; i < paths.Length; ++i)
                listTargetFile.Add(new TargetFileInfo() { Name = Path.GetFileName(paths[i]), Path = paths[i] });
            listTargetFile.Sort((l, r) => l.Name.CompareTo(r.Name));

            int Count = 0;
            foreach (var targetInfo in listTargetFile)
            {
                if (dicMoveTarget.ContainsKey(targetInfo.Name))
                {
                    File.Copy(targetInfo.Path, szDestDirectoryPath + "\\" + targetInfo.Name, true);
                    ++Count;
                }
            }

            MessageBox.Show(string.Format("Complete. count : {0}", Count), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitData_SourDirectoryPath()
        {
            szSourDirectoryPath = string.Empty;
        }

        private void InitData_DestDirectoryPath()
        {
            szDestDirectoryPath = string.Empty;
        }

        private void RefreshUI_SourDirectoryPath()
        {
            if (string.IsNullOrEmpty(szSourDirectoryPath) == false)
                textBoxSour.Text = szSourDirectoryPath;
            else
                textBoxSour.Text = "NONE";
        }

        private void RefreshUI_DestDirectoryPath()
        {
            if (string.IsNullOrEmpty(szDestDirectoryPath) == false)
                textBoxDest.Text = szDestDirectoryPath;
            else
                textBoxDest.Text = "NONE";
        }
    }
}
