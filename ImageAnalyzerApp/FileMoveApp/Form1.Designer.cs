namespace FileMoveApp
{
    partial class FileMoveForm
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
            this.textBoxSour = new System.Windows.Forms.TextBox();
            this.textBoxDest = new System.Windows.Forms.TextBox();
            this.buttonSour = new System.Windows.Forms.Button();
            this.buttonDest = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.folderBrowserDialogForMove = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxNames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSour
            // 
            this.textBoxSour.Location = new System.Drawing.Point(12, 26);
            this.textBoxSour.Name = "textBoxSour";
            this.textBoxSour.ReadOnly = true;
            this.textBoxSour.Size = new System.Drawing.Size(407, 21);
            this.textBoxSour.TabIndex = 0;
            // 
            // textBoxDest
            // 
            this.textBoxDest.Location = new System.Drawing.Point(12, 72);
            this.textBoxDest.Name = "textBoxDest";
            this.textBoxDest.ReadOnly = true;
            this.textBoxDest.Size = new System.Drawing.Size(407, 21);
            this.textBoxDest.TabIndex = 1;
            // 
            // buttonSour
            // 
            this.buttonSour.Location = new System.Drawing.Point(441, 26);
            this.buttonSour.Name = "buttonSour";
            this.buttonSour.Size = new System.Drawing.Size(107, 21);
            this.buttonSour.TabIndex = 2;
            this.buttonSour.Text = "Sour";
            this.buttonSour.UseVisualStyleBackColor = true;
            this.buttonSour.Click += new System.EventHandler(this.buttonSour_Click);
            // 
            // buttonDest
            // 
            this.buttonDest.Location = new System.Drawing.Point(441, 72);
            this.buttonDest.Name = "buttonDest";
            this.buttonDest.Size = new System.Drawing.Size(107, 21);
            this.buttonDest.TabIndex = 3;
            this.buttonDest.Text = "Dest";
            this.buttonDest.UseVisualStyleBackColor = true;
            this.buttonDest.Click += new System.EventHandler(this.buttonDest_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(441, 390);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(107, 21);
            this.buttonDo.TabIndex = 4;
            this.buttonDo.Text = "Copy";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // textBoxNames
            // 
            this.textBoxNames.Location = new System.Drawing.Point(12, 112);
            this.textBoxNames.Multiline = true;
            this.textBoxNames.Name = "textBoxNames";
            this.textBoxNames.Size = new System.Drawing.Size(407, 299);
            this.textBoxNames.TabIndex = 5;
            // 
            // FileMoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 423);
            this.Controls.Add(this.textBoxNames);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonDest);
            this.Controls.Add(this.buttonSour);
            this.Controls.Add(this.textBoxDest);
            this.Controls.Add(this.textBoxSour);
            this.Name = "FileMoveForm";
            this.Text = "FileCopy";
            this.Load += new System.EventHandler(this.FileMoveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSour;
        private System.Windows.Forms.TextBox textBoxDest;
        private System.Windows.Forms.Button buttonSour;
        private System.Windows.Forms.Button buttonDest;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogForMove;
        private System.Windows.Forms.TextBox textBoxNames;
    }
}

