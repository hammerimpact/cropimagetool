namespace ImageAnalyzerApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRectXMin = new System.Windows.Forms.TextBox();
            this.textBoxRectYMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRectXMax = new System.Windows.Forms.TextBox();
            this.textBoxRectYMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveResultFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonSearchSavePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMultiCount = new System.Windows.Forms.TextBox();
            this.textBoxMultiDirection = new System.Windows.Forms.TextBox();
            this.buttonChangeMultiDirection = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonChangeMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(608, 298);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(148, 37);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Files";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(29, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.ReadOnly = true;
            this.textBoxFilePath.Size = new System.Drawing.Size(637, 21);
            this.textBoxFilePath.TabIndex = 8;
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(672, 12);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(84, 21);
            this.button_Load.TabIndex = 9;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "XMin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "YMin";
            // 
            // textBoxRectXMin
            // 
            this.textBoxRectXMin.Location = new System.Drawing.Point(267, 255);
            this.textBoxRectXMin.Name = "textBoxRectXMin";
            this.textBoxRectXMin.Size = new System.Drawing.Size(112, 21);
            this.textBoxRectXMin.TabIndex = 13;
            this.textBoxRectXMin.TextChanged += new System.EventHandler(this.textBoxRectXMin_TextChanged);
            this.textBoxRectXMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRectXMin_KeyPress);
            // 
            // textBoxRectYMin
            // 
            this.textBoxRectYMin.Location = new System.Drawing.Point(267, 292);
            this.textBoxRectYMin.Name = "textBoxRectYMin";
            this.textBoxRectYMin.Size = new System.Drawing.Size(112, 21);
            this.textBoxRectYMin.TabIndex = 14;
            this.textBoxRectYMin.TextChanged += new System.EventHandler(this.textBoxRectYMin_TextChanged);
            this.textBoxRectYMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRectYMin_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "XMax";
            // 
            // textBoxRectXMax
            // 
            this.textBoxRectXMax.Location = new System.Drawing.Point(267, 332);
            this.textBoxRectXMax.Name = "textBoxRectXMax";
            this.textBoxRectXMax.Size = new System.Drawing.Size(112, 21);
            this.textBoxRectXMax.TabIndex = 16;
            this.textBoxRectXMax.TextChanged += new System.EventHandler(this.textBoxRectXMax_TextChanged);
            this.textBoxRectXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRectXMax_KeyPress);
            // 
            // textBoxRectYMax
            // 
            this.textBoxRectYMax.Location = new System.Drawing.Point(267, 368);
            this.textBoxRectYMax.Name = "textBoxRectYMax";
            this.textBoxRectYMax.Size = new System.Drawing.Size(112, 21);
            this.textBoxRectYMax.TabIndex = 17;
            this.textBoxRectYMax.TextChanged += new System.EventHandler(this.textBoxRectYMax_TextChanged);
            this.textBoxRectYMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRectYMax_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "YMax";
            // 
            // listViewFiles
            // 
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.Location = new System.Drawing.Point(29, 114);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(189, 275);
            this.listViewFiles.TabIndex = 21;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            this.listViewFiles.Click += new System.EventHandler(this.listViewFiles_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(608, 341);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(148, 37);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveResultFileDialog
            // 
            this.saveResultFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveResultFileDialog_FileOk);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(29, 395);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(727, 61);
            this.textBoxLog.TabIndex = 27;
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(29, 48);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.ReadOnly = true;
            this.textBoxSavePath.Size = new System.Drawing.Size(637, 21);
            this.textBoxSavePath.TabIndex = 30;
            // 
            // buttonSearchSavePath
            // 
            this.buttonSearchSavePath.Location = new System.Drawing.Point(672, 47);
            this.buttonSearchSavePath.Name = "buttonSearchSavePath";
            this.buttonSearchSavePath.Size = new System.Drawing.Size(84, 21);
            this.buttonSearchSavePath.TabIndex = 31;
            this.buttonSearchSavePath.Text = "Search";
            this.buttonSearchSavePath.UseVisualStyleBackColor = true;
            this.buttonSearchSavePath.Click += new System.EventHandler(this.buttonSearchSavePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "Single Crop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "Multi Crop";
            // 
            // textBoxMultiCount
            // 
            this.textBoxMultiCount.Location = new System.Drawing.Point(470, 332);
            this.textBoxMultiCount.Name = "textBoxMultiCount";
            this.textBoxMultiCount.Size = new System.Drawing.Size(112, 21);
            this.textBoxMultiCount.TabIndex = 39;
            this.textBoxMultiCount.TextChanged += new System.EventHandler(this.textBoxMultiCount_TextChanged);
            this.textBoxMultiCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMultiCount_KeyPress);
            // 
            // textBoxMultiDirection
            // 
            this.textBoxMultiDirection.Location = new System.Drawing.Point(469, 367);
            this.textBoxMultiDirection.Name = "textBoxMultiDirection";
            this.textBoxMultiDirection.ReadOnly = true;
            this.textBoxMultiDirection.Size = new System.Drawing.Size(112, 21);
            this.textBoxMultiDirection.TabIndex = 42;
            // 
            // buttonChangeMultiDirection
            // 
            this.buttonChangeMultiDirection.Location = new System.Drawing.Point(398, 367);
            this.buttonChangeMultiDirection.Name = "buttonChangeMultiDirection";
            this.buttonChangeMultiDirection.Size = new System.Drawing.Size(66, 21);
            this.buttonChangeMultiDirection.TabIndex = 43;
            this.buttonChangeMultiDirection.Text = "Direction";
            this.buttonChangeMultiDirection.UseVisualStyleBackColor = true;
            this.buttonChangeMultiDirection.Click += new System.EventHandler(this.buttonChangeMultiDirection_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "Count";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(229, 114);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(527, 99);
            this.textBoxState.TabIndex = 44;
            // 
            // buttonChangeMode
            // 
            this.buttonChangeMode.Location = new System.Drawing.Point(381, 223);
            this.buttonChangeMode.Name = "buttonChangeMode";
            this.buttonChangeMode.Size = new System.Drawing.Size(66, 21);
            this.buttonChangeMode.TabIndex = 45;
            this.buttonChangeMode.Text = "Mode";
            this.buttonChangeMode.UseVisualStyleBackColor = true;
            this.buttonChangeMode.Click += new System.EventHandler(this.buttonChangeMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 473);
            this.Controls.Add(this.buttonChangeMode);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.buttonChangeMultiDirection);
            this.Controls.Add(this.textBoxMultiDirection);
            this.Controls.Add(this.textBoxMultiCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchSavePath);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRectYMax);
            this.Controls.Add(this.textBoxRectXMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRectYMin);
            this.Controls.Add(this.textBoxRectXMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Clear);
            this.Name = "Form1";
            this.Text = "Crop Image Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRectXMin;
        private System.Windows.Forms.TextBox textBoxRectYMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRectXMax;
        private System.Windows.Forms.TextBox textBoxRectYMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveResultFileDialog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonSearchSavePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMultiCount;
        private System.Windows.Forms.TextBox textBoxMultiDirection;
        private System.Windows.Forms.Button buttonChangeMultiDirection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonChangeMode;
    }
}

