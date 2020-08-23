using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageAnalyzerApp
{
    public partial class Form1 : Form
    {
        private static Form1 _instance = null;
        public static Form1 Instance => _instance;

        struct TargetFileInfo
        {
            public string Name;
            public string Path;
        }

        // Private variables
        private string szLoadDirectoryPath = string.Empty;
        private string szSaveDirectoryPath = string.Empty;
        private List<TargetFileInfo> listTargetFileInfos = new List<TargetFileInfo>();
        private CropInfo kCropInfo = new CropInfo();

        // Private variables - results

        public Form1()
        {
            _instance = this;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Init Data
            InitData_LoadDirectoryPath();
            InitData_SaveDirectoryPath();
            InitData_DirectoryFileNames();
            InitData_CropInfo();

            // Refresh UI
            RefreshUI_LoadDirectoryPath();
            RefreshUI_SaveDirectoryPath();
            RefreshUI_DirectoryFileNames();
            RefreshUI_CropInfoState();
            RefreshUI_SingleCropRect();
            RefreshUI_MultiCropData();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Init Data
            InitData_LoadDirectoryPath();
            InitData_SaveDirectoryPath();
            InitData_DirectoryFileNames();
            InitData_CropInfo();

            // Refresh Data
            RefreshUI_LoadDirectoryPath();
            RefreshUI_SaveDirectoryPath();
            RefreshUI_DirectoryFileNames();
            RefreshUI_CropInfoState();
            RefreshUI_SingleCropRect();
            RefreshUI_MultiCropData();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(szSaveDirectoryPath))
            {
                MessageBox.Show("Save Path Empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Ready to Save?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            switch (result)
            {
                case DialogResult.Yes:
                    ExecCropAll();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            var result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            if (Directory.Exists(folderBrowserDialog.SelectedPath) == false)
                return;

            // Refresh Data
            szLoadDirectoryPath = folderBrowserDialog.SelectedPath;

            listTargetFileInfos.Clear();

            var paths = Directory.GetFiles(szLoadDirectoryPath, "*.jpg");
            if (null != paths)
            {
                for (int i = 0; i < paths.Length; ++i)
                    listTargetFileInfos.Add(new TargetFileInfo() { Name = Path.GetFileName(paths[i]), Path = paths[i]});

                listTargetFileInfos.Sort((l, r)=> l.Name.CompareTo(r.Name));
            }

            // Refresh UI
            RefreshUI_LoadDirectoryPath();
            RefreshUI_DirectoryFileNames();
        }

        private void buttonSearchSavePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            var result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.OK)
                return;

            if (Directory.Exists(folderBrowserDialog.SelectedPath) == false)
                return;

            // Refresh Data
            szSaveDirectoryPath = folderBrowserDialog.SelectedPath;

            // Refresh UI
            RefreshUI_SaveDirectoryPath();
        }


        private void buttonChangeMode_Click(object sender, EventArgs e)
        {
            // Refresh Data
            int nIndex = (int)kCropInfo.eType + 1;
            nIndex %= (int)CropInfo.Type.Max;

            kCropInfo.eType = (CropInfo.Type)nIndex;

            // Refresh UI
            RefreshUI_CropInfoState();
        }


        private void buttonChangeMultiDirection_Click(object sender, EventArgs e)
        {
            // Refresh Data
            int nIndex = (int)kCropInfo.eMultiDirection + 1;
            nIndex %= (int)CropInfo.Direction.Max;

            kCropInfo.eMultiDirection = (CropInfo.Direction)nIndex;

            // Refresh UI
            RefreshUI_CropInfoState();
            RefreshUI_MultiCropData();
        }

        private void listViewFiles_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count == 0)
                return;

            var selectedItem = listViewFiles.SelectedItems[0];
            var key = selectedItem.Text;

            var _name = string.Empty;
            var _path = string.Empty;

            for (int i = 0; i < listTargetFileInfos.Count; ++i)
            {
                if (listTargetFileInfos[i].Name == key)
                {
                    _name = listTargetFileInfos[i].Name;
                    _path = listTargetFileInfos[i].Path;
                    break;
                }
            }

            if (string.IsNullOrEmpty(_name))
                return;

            var dlg = new FormImageView();
            dlg.SetData(_name, _path, kCropInfo, onFormImageView_Copy);
            dlg.Show();
        }


        private void textBoxRectXMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            _check_textbox_keypress_allow_number_only_(e);
        }

        private void textBoxRectYMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            _check_textbox_keypress_allow_number_only_(e);
        }

        private void textBoxRectXMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            _check_textbox_keypress_allow_number_only_(e);
        }

        private void textBoxRectYMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            _check_textbox_keypress_allow_number_only_(e);
        }

        private void textBoxMultiCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            _check_textbox_keypress_allow_number_only_(e);
        }

        private void _check_textbox_keypress_allow_number_only_(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete);
        }

        private void textBoxRectXMin_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            var target = textBoxRectXMin;
            if (string.IsNullOrEmpty(target.Text))
            {
                target.Text = 0.ToString();
                return;
            }

            if (int.TryParse(target.Text, out value) == false)
                return;

            // Refresh Data
            var prev = kCropInfo.kSingleCrop.XMin;
            kCropInfo.kSingleCrop.XMin = value;

            Util.Log(string.Format("XMin changed {0}=>{1}", prev, kCropInfo.kSingleCrop.XMin));

            // Refresh UI
            RefreshUI_CropInfoState();
        }


        private void textBoxRectYMin_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            var target = textBoxRectYMin;
            if (string.IsNullOrEmpty(target.Text))
            {
                target.Text = 0.ToString();
                return;
            }

            if (int.TryParse(target.Text, out value) == false)
                return;

            // Refresh Data
            var prev = kCropInfo.kSingleCrop.YMin;
            kCropInfo.kSingleCrop.YMin = value;

            Util.Log(string.Format("YMin changed {0}=>{1}", prev, kCropInfo.kSingleCrop.YMin));

            // Refresh UI
            RefreshUI_CropInfoState();
        }


        private void textBoxRectXMax_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            var target = textBoxRectXMax;
            if (string.IsNullOrEmpty(target.Text))
            {
                target.Text = 0.ToString();
                return;
            }

            if (int.TryParse(target.Text, out value) == false)
                return;

            // Refresh Data
            var prev = kCropInfo.kSingleCrop.XMax;
            kCropInfo.kSingleCrop.XMax = value;

            Util.Log(string.Format("XMax changed {0}=>{1}", prev, kCropInfo.kSingleCrop.XMax));

            // Refresh UI
            RefreshUI_CropInfoState();
        }


        private void textBoxRectYMax_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            var target = textBoxRectYMax;
            if (string.IsNullOrEmpty(target.Text))
            {
                target.Text = 0.ToString();
                return;
            }

            if (int.TryParse(target.Text, out value) == false)
                return;

            // Refresh Data
            var prev = kCropInfo.kSingleCrop.YMax;
            kCropInfo.kSingleCrop.YMax = value;

            Util.Log(string.Format("YMax changed {0}=>{1}", prev, kCropInfo.kSingleCrop.YMax));

            // Refresh UI
            RefreshUI_CropInfoState();
        }

        private void textBoxMultiCount_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            var target = textBoxMultiCount;
            if (string.IsNullOrEmpty(target.Text))
            {
                target.Text = 0.ToString();
                return;
            }

            if (int.TryParse(target.Text, out value) == false)
                return;

            // Refresh Data
            var prev = kCropInfo.nMultiCount;
            kCropInfo.nMultiCount = value;

            Util.Log(string.Format("YMax changed {0}=>{1}", prev, kCropInfo.nMultiCount));

            // Refresh UI
            RefreshUI_CropInfoState();
        }


        private void onFormImageView_Copy(CropInfo kCropInfo)
        {
            // Refresh Data
            this.kCropInfo.Copy(kCropInfo);

            // Refresh UI
            RefreshUI_CropInfoState();
            RefreshUI_SingleCropRect();
            RefreshUI_MultiCropData();
        }

        private void InitData_LoadDirectoryPath()
        {
            szLoadDirectoryPath = string.Empty;
        }

        private void InitData_SaveDirectoryPath()
        {
            szSaveDirectoryPath = string.Empty;
        }

        private void InitData_DirectoryFileNames()
        {
            listTargetFileInfos.Clear();
        }

        private void InitData_CropInfo()
        {
            kCropInfo = new CropInfo();
            kCropInfo.eType = CropInfo.Type.CropSingle;
            kCropInfo.kSingleCrop = new Rect();
            kCropInfo.nMultiCount = 1;
            kCropInfo.eMultiDirection = CropInfo.Direction.Left;
        }

        private void RefreshUI_LoadDirectoryPath()
        {
            if (string.IsNullOrEmpty(szLoadDirectoryPath) == false)
                textBoxFilePath.Text = szLoadDirectoryPath;
            else
                textBoxFilePath.Text = "NONE";
        }

        private void RefreshUI_SaveDirectoryPath()
        {
            if (string.IsNullOrEmpty(szSaveDirectoryPath) == false)
                textBoxSavePath.Text = szSaveDirectoryPath;
            else
                textBoxSavePath.Text = "NONE";
        }

        private void RefreshUI_DirectoryFileNames()
        {
            listViewFiles.Clear();

            listViewFiles.BeginUpdate();

            for (int i = 0; i < listTargetFileInfos.Count; ++i)
            {
                var lvi = new ListViewItem(listTargetFileInfos[i].Name);
                listViewFiles.Items.Add(lvi);
            }
            listViewFiles.Columns.Add("FileName", 140);

            listViewFiles.EndUpdate();
        }

        private StringBuilder sbCropInfoState = new StringBuilder();
        private void RefreshUI_CropInfoState()
        {
            sbCropInfoState.Clear();
            sbCropInfoState.AppendLine(string.Format("Selected Mode : {0}", kCropInfo.eType));
            sbCropInfoState.AppendLine(string.Format("Single Rect : {0}.{1}/{2}.{3}", kCropInfo.kSingleCrop.XMin, kCropInfo.kSingleCrop.YMin, kCropInfo.kSingleCrop.XMax, kCropInfo.kSingleCrop.YMax));
            sbCropInfoState.AppendLine(string.Format("Multi Count : {0} // Direction : {1}", kCropInfo.nMultiCount, kCropInfo.eMultiDirection));

            textBoxState.Text = sbCropInfoState.ToString();
        }

        private void RefreshUI_SingleCropRect()
        {
            textBoxRectXMin.Text = kCropInfo.kSingleCrop.XMin.ToString();
            textBoxRectXMax.Text = kCropInfo.kSingleCrop.XMax.ToString();
            textBoxRectYMin.Text = kCropInfo.kSingleCrop.YMin.ToString();
            textBoxRectYMax.Text = kCropInfo.kSingleCrop.YMax.ToString();
        }

        private void RefreshUI_MultiCropData()
        {
            textBoxMultiDirection.Text = kCropInfo.eMultiDirection.ToString();
            textBoxMultiCount.Text = kCropInfo.nMultiCount.ToString();
        }

        private List<string> listLog = new List<string>();
        private StringBuilder sbLog = new StringBuilder();
        public void SetLog(string log)
        {
            if (string.IsNullOrEmpty(log))
                return;

            // Refresh Data
            if (listLog.Count >= 3)
                listLog.RemoveAt(0);

            listLog.Add(log);

            sbLog.Clear();
            for (int i = 0; i < listLog.Count; ++i)
                sbLog.AppendLine(listLog[i]);

            // Refresh UI
            textBoxLog.Text = sbLog.ToString();
        }

        // ExecCropAll
        private void ExecCropAll()
        {
            // Refresh Data 2
            Util.Log("===============ExecCropAll Start===============");

            bool bFailed = false;
            int nSuccess = 0;
            int nAll = listTargetFileInfos.Count;
            for (int i = 0; i < nAll; ++i)
            {
                var reason = ExecCrop(i, listTargetFileInfos[i].Name, listTargetFileInfos[i].Path);
                if (reason == EnumFailedReason.None)
                    ++nSuccess;
                else
                {
                    bFailed = true;
                    Util.Log(string.Format("ExecCropAnalize Failed[{0}] : {1}", listTargetFileInfos[i].Name, reason));
                    break;
                }
            }

            if (bFailed == false)
            {
                Util.Log(string.Format("===============ExecCropAll Complete[{0}/{1}]===============", nSuccess, nAll));
            }
            else
            {
                //// Refresh Data
                //InitData_ResultTypeInfo();
                //InitData_AnalyzeResultInfo();
            }

            //// Refresh UI
            //RefreshUI_ResultTypeInfo();
            //RefreshUI_AnalyzeResultInfo();

            //SaveResultType();
        }

        //private void SaveResultType()
        //{
        //    for (int i = 0; i < listResultTypeInfo.Count; ++i)
        //    {
        //        if (listResultTypeInfo[i].bitmap != null)
        //            listResultTypeInfo[i].bitmap.Save(szDirectoryPath + string.Format("\\image{0}.png", i), System.Drawing.Imaging.ImageFormat.Png);
        //    }
        //}

        private enum EnumFailedReason
        {
            None,
            FileNotExist,
            BitmapLoadFailed,
            RectCropInvalid,
            BitmapCloneFailed,
        }

        private EnumFailedReason ExecCrop(int index, string Name, string path)
        {
            if (File.Exists(path) == false)
                return EnumFailedReason.FileNotExist;

            var listRect = kCropInfo.GetRectList();
            if (listRect.Count == 0)
                return EnumFailedReason.RectCropInvalid;

            var bitmapOrigin = Util.LoadBitmap(path);
            if (null == bitmapOrigin)
                return EnumFailedReason.BitmapLoadFailed;

            for (int i = 0; i < listRect.Count; ++i)
            {
                var cropRectangle = new Rectangle(listRect[i].XMin, listRect[i].YMin, listRect[i].Width, listRect[i].Height);
                var bitmapClone = bitmapOrigin.Clone(cropRectangle, bitmapOrigin.PixelFormat);
                if (null == bitmapClone)
                {
                    bitmapOrigin.Dispose();
                    return EnumFailedReason.BitmapCloneFailed;
                }

                var fileName = string.Format("\\{0}_{1:D3}.png", Name, i);
                bitmapClone.Save(szSaveDirectoryPath + fileName, System.Drawing.Imaging.ImageFormat.Png);

                bitmapClone.Dispose();
            }
            
            bitmapOrigin.Dispose();
            return EnumFailedReason.None;
        }

        #region Useless Callback
        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void saveResultFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }


        #endregion

    }
}
