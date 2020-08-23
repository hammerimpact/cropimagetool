using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnalyzerApp
{
    public partial class FormImageView : Form
    {
        // Private variables
        private string fileName = string.Empty;
        private string path = string.Empty;
        private Action<CropInfo> funcOnCopy = null;
        private CropInfo kCropInfoOrigin = new CropInfo();
        private CropInfo kCropInfo = new CropInfo();

        private bool isEditCropRectMode = false;


        public void SetData(string fileName, string path, CropInfo kCropInfo, Action<CropInfo> funcOnCopy)
        {
            this.fileName = fileName;
            this.path = path;
            this.funcOnCopy = funcOnCopy;
            this.kCropInfoOrigin.Copy(kCropInfo);
            this.kCropInfo.Copy(kCropInfo);
        }

        public FormImageView()
        {
            InitializeComponent();
        }

        private void FormImageView_Load(object sender, EventArgs e)
        {
            // Refresh UI
            labelName.Text = fileName;
            textBoxPath.Text = path;
            pictureBoxImage.Image = Util.LoadBitmap(path);
            RefreshUI_CropState();
        }


        private void buttonShowOriginRect_Click(object sender, EventArgs e)
        {
            // Refresh Data
            kCropInfo.Copy(kCropInfoOrigin);

            // Refresh UI
            RefreshUI_DrawCropRect();
            RefreshUI_CropState();
        }

        private void buttonToggleRect_Click(object sender, EventArgs e)
        {
            // Refresh Data
            isEditCropRectMode = !isEditCropRectMode;

            // Refresh UI
            RefreshUI_CropState();
        }


        private void buttonCopy_Click(object sender, EventArgs e)
        {
            funcOnCopy?.Invoke(kCropInfo);

            MessageBox.Show("Copy Complete", "Information", MessageBoxButtons.OK);
        }

        private Point kTempPointDown = new Point();
        private Point kTempPointUp = new Point();

        private void pictureBoxImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isEditCropRectMode)
                return;

            kTempPointDown = pictureBoxImage.PointToClient(Cursor.Position);

            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void pictureBoxImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isEditCropRectMode)
                return;

            kTempPointUp = pictureBoxImage.PointToClient(Cursor.Position);

            // Refresh Data
            kCropInfo.kSingleCrop = new Rect(kTempPointDown.X, kTempPointDown.Y, kTempPointUp.X, kTempPointUp.Y);

            // Refresh UI
            RefreshUI_DrawCropRect();
            RefreshUI_CropState();
        }


        private void buttonRectXPlus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonRectXPlus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            kCropInfo.kSingleCrop.XMax += 1;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }


        private void buttonRectXMinus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonRectXMinus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            kCropInfo.kSingleCrop.XMax -= 1;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void buttonRectYPlus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonRectYPlus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            kCropInfo.kSingleCrop.YMax += 1;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void buttonRectYMinus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonRectYMinus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            kCropInfo.kSingleCrop.YMax -= 1;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void buttonStartXPlus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonStartXPlus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            var width = kCropInfo.kSingleCrop.Width;
            kCropInfo.kSingleCrop.XMin += 1;
            kCropInfo.kSingleCrop.XMax = kCropInfo.kSingleCrop.XMin + width;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void buttonStartXMinus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonStartXMinus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            var width = kCropInfo.kSingleCrop.Width;
            kCropInfo.kSingleCrop.XMin -= 1;
            kCropInfo.kSingleCrop.XMax = kCropInfo.kSingleCrop.XMin + width;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void buttonStartYPlus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonStartYPlus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            var height = kCropInfo.kSingleCrop.Height;
            kCropInfo.kSingleCrop.YMin += 1;
            kCropInfo.kSingleCrop.YMax = kCropInfo.kSingleCrop.YMin + height;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void buttonStartYMinus_MouseDown(object sender, MouseEventArgs e)
        {
            // Refresh UI
            pictureBoxImage.Invalidate(); // for cleanup lines
        }

        private void buttonStartYMinus_MouseUp(object sender, MouseEventArgs e)
        {
            // Refresh Data
            var height = kCropInfo.kSingleCrop.Height;
            kCropInfo.kSingleCrop.YMin -= 1;
            kCropInfo.kSingleCrop.YMax = kCropInfo.kSingleCrop.YMin + height;

            // Refresh UI
            RefreshUI_CropState();
            RefreshUI_DrawCropRect();
        }

        private void RefreshUI_DrawCropRect()
        {
            var listRect = kCropInfo.GetRectList();

            using (Graphics g = pictureBoxImage.CreateGraphics())
            {
                var pen = new Pen(Color.Red, 1f);

                for (int i = 0; i < listRect.Count; ++i)
                {
                    g.DrawLine(pen, listRect[i].LeftTop,        listRect[i].LeftBottom);
                    g.DrawLine(pen, listRect[i].LeftBottom,     listRect[i].RightBottom);
                    g.DrawLine(pen, listRect[i].RightBottom,    listRect[i].RightTop);
                    g.DrawLine(pen, listRect[i].RightTop,       listRect[i].LeftTop);
                }
            }
        }

        private StringBuilder sbCropState = new StringBuilder();
        private void RefreshUI_CropState()
        {
            sbCropState.Clear();

            sbCropState.AppendLine(string.Format("EditCropMode : {0}", isEditCropRectMode));
            sbCropState.AppendLine(string.Format("XMin : {0} / YMin : {1}", kCropInfo.kSingleCrop.XMin, kCropInfo.kSingleCrop.YMin));
            sbCropState.AppendLine(string.Format("XMax : {0} / YMax : {1}", kCropInfo.kSingleCrop.XMax, kCropInfo.kSingleCrop.YMax));

            textBoxCropState.Text = sbCropState.ToString();
        }

    }
}
