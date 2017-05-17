namespace ImageUploadAmazonS3Test1
{
    partial class testImgUpload
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
            this.openImg_btn = new System.Windows.Forms.Button();
            this.imgDisplay_picBox = new System.Windows.Forms.PictureBox();
            this.saveAsName_txtBox = new System.Windows.Forms.TextBox();
            this.saveAs_lbl = new System.Windows.Forms.Label();
            this.jpg_checkBx = new System.Windows.Forms.CheckBox();
            this.getImgFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileName_txtBx = new System.Windows.Forms.TextBox();
            this.fileNameTestImg_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImg_btn
            // 
            this.openImg_btn.Location = new System.Drawing.Point(742, 569);
            this.openImg_btn.Name = "openImg_btn";
            this.openImg_btn.Size = new System.Drawing.Size(253, 65);
            this.openImg_btn.TabIndex = 0;
            this.openImg_btn.Text = "Display and Save Image";
            this.openImg_btn.UseVisualStyleBackColor = true;
            this.openImg_btn.Click += new System.EventHandler(this.openImg_Click);
            // 
            // imgDisplay_picBox
            // 
            this.imgDisplay_picBox.Location = new System.Drawing.Point(26, 27);
            this.imgDisplay_picBox.Name = "imgDisplay_picBox";
            this.imgDisplay_picBox.Size = new System.Drawing.Size(587, 717);
            this.imgDisplay_picBox.TabIndex = 1;
            this.imgDisplay_picBox.TabStop = false;
            // 
            // saveAsName_txtBox
            // 
            this.saveAsName_txtBox.Location = new System.Drawing.Point(742, 460);
            this.saveAsName_txtBox.Name = "saveAsName_txtBox";
            this.saveAsName_txtBox.Size = new System.Drawing.Size(234, 31);
            this.saveAsName_txtBox.TabIndex = 2;
            // 
            // saveAs_lbl
            // 
            this.saveAs_lbl.AutoSize = true;
            this.saveAs_lbl.Location = new System.Drawing.Point(742, 429);
            this.saveAs_lbl.Name = "saveAs_lbl";
            this.saveAs_lbl.Size = new System.Drawing.Size(110, 25);
            this.saveAs_lbl.TabIndex = 3;
            this.saveAs_lbl.Text = "Save As...";
            // 
            // jpg_checkBx
            // 
            this.jpg_checkBx.AutoSize = true;
            this.jpg_checkBx.Checked = true;
            this.jpg_checkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jpg_checkBx.Location = new System.Drawing.Point(756, 514);
            this.jpg_checkBx.Name = "jpg_checkBx";
            this.jpg_checkBx.Size = new System.Drawing.Size(91, 29);
            this.jpg_checkBx.TabIndex = 4;
            this.jpg_checkBx.Text = ".JPG";
            this.jpg_checkBx.UseVisualStyleBackColor = true;
            // 
            // getImgFile_btn
            // 
            this.getImgFile_btn.Location = new System.Drawing.Point(725, 27);
            this.getImgFile_btn.Name = "getImgFile_btn";
            this.getImgFile_btn.Size = new System.Drawing.Size(251, 74);
            this.getImgFile_btn.TabIndex = 5;
            this.getImgFile_btn.Text = "Which image is being tested?";
            this.getImgFile_btn.UseVisualStyleBackColor = true;
            this.getImgFile_btn.Click += new System.EventHandler(this.getImgFile_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileName_txtBx
            // 
            this.fileName_txtBx.Location = new System.Drawing.Point(725, 154);
            this.fileName_txtBx.Name = "fileName_txtBx";
            this.fileName_txtBx.Size = new System.Drawing.Size(251, 31);
            this.fileName_txtBx.TabIndex = 6;
            // 
            // fileNameTestImg_lbl
            // 
            this.fileNameTestImg_lbl.AutoSize = true;
            this.fileNameTestImg_lbl.Location = new System.Drawing.Point(725, 123);
            this.fileNameTestImg_lbl.Name = "fileNameTestImg_lbl";
            this.fileNameTestImg_lbl.Size = new System.Drawing.Size(229, 25);
            this.fileNameTestImg_lbl.TabIndex = 7;
            this.fileNameTestImg_lbl.Text = "Filename of test image";
            // 
            // testImgUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 814);
            this.Controls.Add(this.fileNameTestImg_lbl);
            this.Controls.Add(this.fileName_txtBx);
            this.Controls.Add(this.getImgFile_btn);
            this.Controls.Add(this.jpg_checkBx);
            this.Controls.Add(this.saveAs_lbl);
            this.Controls.Add(this.saveAsName_txtBox);
            this.Controls.Add(this.imgDisplay_picBox);
            this.Controls.Add(this.openImg_btn);
            this.Name = "testImgUpload";
            this.Text = "Upload Image";
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openImg_btn;
        private System.Windows.Forms.PictureBox imgDisplay_picBox;
        private System.Windows.Forms.TextBox saveAsName_txtBox;
        private System.Windows.Forms.Label saveAs_lbl;
        private System.Windows.Forms.CheckBox jpg_checkBx;
        private System.Windows.Forms.Button getImgFile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileName_txtBx;
        private System.Windows.Forms.Label fileNameTestImg_lbl;
    }
}

