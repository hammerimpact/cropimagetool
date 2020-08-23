namespace ImageAnalyzerApp
{
    partial class FormImageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonShowOriginRect = new System.Windows.Forms.Button();
            this.buttonToggleRect = new System.Windows.Forms.Button();
            this.textBoxCropState = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonRectXPlus = new System.Windows.Forms.Button();
            this.buttonRectXMinus = new System.Windows.Forms.Button();
            this.buttonRectYPlus = new System.Windows.Forms.Button();
            this.buttonRectYMinus = new System.Windows.Forms.Button();
            this.buttonStartXPlus = new System.Windows.Forms.Button();
            this.buttonStartXMinus = new System.Windows.Forms.Button();
            this.buttonStartYPlus = new System.Windows.Forms.Button();
            this.buttonStartYMinus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(15, 190);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(508, 455);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseDown);
            this.pictureBoxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImage_MouseUp);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 12);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "name";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(15, 32);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(508, 21);
            this.textBoxPath.TabIndex = 2;
            // 
            // buttonShowOriginRect
            // 
            this.buttonShowOriginRect.Location = new System.Drawing.Point(15, 59);
            this.buttonShowOriginRect.Name = "buttonShowOriginRect";
            this.buttonShowOriginRect.Size = new System.Drawing.Size(133, 27);
            this.buttonShowOriginRect.TabIndex = 3;
            this.buttonShowOriginRect.Text = "ReturnOriginCrop";
            this.buttonShowOriginRect.UseVisualStyleBackColor = true;
            this.buttonShowOriginRect.Click += new System.EventHandler(this.buttonShowOriginRect_Click);
            // 
            // buttonToggleRect
            // 
            this.buttonToggleRect.Location = new System.Drawing.Point(15, 92);
            this.buttonToggleRect.Name = "buttonToggleRect";
            this.buttonToggleRect.Size = new System.Drawing.Size(133, 27);
            this.buttonToggleRect.TabIndex = 4;
            this.buttonToggleRect.Text = "ToggleRect";
            this.buttonToggleRect.UseVisualStyleBackColor = true;
            this.buttonToggleRect.Click += new System.EventHandler(this.buttonToggleRect_Click);
            // 
            // textBoxCropState
            // 
            this.textBoxCropState.Location = new System.Drawing.Point(316, 59);
            this.textBoxCropState.Multiline = true;
            this.textBoxCropState.Name = "textBoxCropState";
            this.textBoxCropState.ReadOnly = true;
            this.textBoxCropState.Size = new System.Drawing.Size(207, 60);
            this.textBoxCropState.TabIndex = 5;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(390, 125);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(133, 27);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonRectXPlus
            // 
            this.buttonRectXPlus.Location = new System.Drawing.Point(164, 59);
            this.buttonRectXPlus.Name = "buttonRectXPlus";
            this.buttonRectXPlus.Size = new System.Drawing.Size(59, 27);
            this.buttonRectXPlus.TabIndex = 7;
            this.buttonRectXPlus.Text = "RectX+";
            this.buttonRectXPlus.UseVisualStyleBackColor = true;
            this.buttonRectXPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRectXPlus_MouseDown);
            this.buttonRectXPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRectXPlus_MouseUp);
            // 
            // buttonRectXMinus
            // 
            this.buttonRectXMinus.Location = new System.Drawing.Point(229, 59);
            this.buttonRectXMinus.Name = "buttonRectXMinus";
            this.buttonRectXMinus.Size = new System.Drawing.Size(59, 27);
            this.buttonRectXMinus.TabIndex = 8;
            this.buttonRectXMinus.Text = "RectX-";
            this.buttonRectXMinus.UseVisualStyleBackColor = true;
            this.buttonRectXMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRectXMinus_MouseDown);
            this.buttonRectXMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRectXMinus_MouseUp);
            // 
            // buttonRectYPlus
            // 
            this.buttonRectYPlus.Location = new System.Drawing.Point(164, 92);
            this.buttonRectYPlus.Name = "buttonRectYPlus";
            this.buttonRectYPlus.Size = new System.Drawing.Size(59, 27);
            this.buttonRectYPlus.TabIndex = 9;
            this.buttonRectYPlus.Text = "RectY+";
            this.buttonRectYPlus.UseVisualStyleBackColor = true;
            this.buttonRectYPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRectYPlus_MouseDown);
            this.buttonRectYPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRectYPlus_MouseUp);
            // 
            // buttonRectYMinus
            // 
            this.buttonRectYMinus.Location = new System.Drawing.Point(229, 92);
            this.buttonRectYMinus.Name = "buttonRectYMinus";
            this.buttonRectYMinus.Size = new System.Drawing.Size(59, 27);
            this.buttonRectYMinus.TabIndex = 10;
            this.buttonRectYMinus.Text = "RectY-";
            this.buttonRectYMinus.UseVisualStyleBackColor = true;
            this.buttonRectYMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRectYMinus_MouseDown);
            this.buttonRectYMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRectYMinus_MouseUp);
            // 
            // buttonStartXPlus
            // 
            this.buttonStartXPlus.Location = new System.Drawing.Point(164, 125);
            this.buttonStartXPlus.Name = "buttonStartXPlus";
            this.buttonStartXPlus.Size = new System.Drawing.Size(59, 27);
            this.buttonStartXPlus.TabIndex = 11;
            this.buttonStartXPlus.Text = "StartX+";
            this.buttonStartXPlus.UseVisualStyleBackColor = true;
            this.buttonStartXPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartXPlus_MouseDown);
            this.buttonStartXPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStartXPlus_MouseUp);
            // 
            // buttonStartXMinus
            // 
            this.buttonStartXMinus.Location = new System.Drawing.Point(229, 124);
            this.buttonStartXMinus.Name = "buttonStartXMinus";
            this.buttonStartXMinus.Size = new System.Drawing.Size(59, 27);
            this.buttonStartXMinus.TabIndex = 12;
            this.buttonStartXMinus.Text = "StartX-";
            this.buttonStartXMinus.UseVisualStyleBackColor = true;
            this.buttonStartXMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartXMinus_MouseDown);
            this.buttonStartXMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStartXMinus_MouseUp);
            // 
            // buttonStartYPlus
            // 
            this.buttonStartYPlus.Location = new System.Drawing.Point(164, 157);
            this.buttonStartYPlus.Name = "buttonStartYPlus";
            this.buttonStartYPlus.Size = new System.Drawing.Size(59, 27);
            this.buttonStartYPlus.TabIndex = 13;
            this.buttonStartYPlus.Text = "StartY+";
            this.buttonStartYPlus.UseVisualStyleBackColor = true;
            this.buttonStartYPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartYPlus_MouseDown);
            this.buttonStartYPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStartYPlus_MouseUp);
            // 
            // buttonStartYMinus
            // 
            this.buttonStartYMinus.Location = new System.Drawing.Point(229, 157);
            this.buttonStartYMinus.Name = "buttonStartYMinus";
            this.buttonStartYMinus.Size = new System.Drawing.Size(59, 27);
            this.buttonStartYMinus.TabIndex = 14;
            this.buttonStartYMinus.Text = "StartY-";
            this.buttonStartYMinus.UseVisualStyleBackColor = true;
            this.buttonStartYMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartYMinus_MouseDown);
            this.buttonStartYMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStartYMinus_MouseUp);
            // 
            // FormImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 657);
            this.Controls.Add(this.buttonStartYMinus);
            this.Controls.Add(this.buttonStartYPlus);
            this.Controls.Add(this.buttonStartXMinus);
            this.Controls.Add(this.buttonStartXPlus);
            this.Controls.Add(this.buttonRectYMinus);
            this.Controls.Add(this.buttonRectYPlus);
            this.Controls.Add(this.buttonRectXMinus);
            this.Controls.Add(this.buttonRectXPlus);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxCropState);
            this.Controls.Add(this.buttonToggleRect);
            this.Controls.Add(this.buttonShowOriginRect);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "FormImageView";
            this.Text = "FormImageView";
            this.Load += new System.EventHandler(this.FormImageView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonShowOriginRect;
        private System.Windows.Forms.Button buttonToggleRect;
        private System.Windows.Forms.TextBox textBoxCropState;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonRectXPlus;
        private System.Windows.Forms.Button buttonRectXMinus;
        private System.Windows.Forms.Button buttonRectYPlus;
        private System.Windows.Forms.Button buttonRectYMinus;
        private System.Windows.Forms.Button buttonStartXPlus;
        private System.Windows.Forms.Button buttonStartXMinus;
        private System.Windows.Forms.Button buttonStartYPlus;
        private System.Windows.Forms.Button buttonStartYMinus;
    }
}