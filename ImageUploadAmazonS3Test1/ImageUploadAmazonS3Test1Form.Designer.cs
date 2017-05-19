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
            this.uploadImg_btn = new System.Windows.Forms.Button();
            this.imgDisplay_picBox = new System.Windows.Forms.PictureBox();
            this.saveAsName_txtBox = new System.Windows.Forms.TextBox();
            this.saveAs_lbl = new System.Windows.Forms.Label();
            this.jpg_checkBx = new System.Windows.Forms.CheckBox();
            this.getImgFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileName_txtBx = new System.Windows.Forms.TextBox();
            this.fileNameTestImg_lbl = new System.Windows.Forms.Label();
            this.username_txtBx = new System.Windows.Forms.TextBox();
            this.password_txtBx = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.token_txtBx = new System.Windows.Forms.TextBox();
            this.token_lbl = new System.Windows.Forms.Label();
            this.saveImg_progressBar = new System.Windows.Forms.ProgressBar();
            this.organizationId_txtBx = new System.Windows.Forms.TextBox();
            this.testConfigId_txtBx = new System.Windows.Forms.TextBox();
            this.version_txtBx = new System.Windows.Forms.TextBox();
            this.studentId_txtBx = new System.Windows.Forms.TextBox();
            this.page_txtBx = new System.Windows.Forms.TextBox();
            this.fillOut_lbl = new System.Windows.Forms.Label();
            this.urlPost_txtBx = new System.Windows.Forms.TextBox();
            this.download_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadImg_btn
            // 
            this.uploadImg_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.uploadImg_btn.Location = new System.Drawing.Point(849, 678);
            this.uploadImg_btn.Name = "uploadImg_btn";
            this.uploadImg_btn.Size = new System.Drawing.Size(253, 65);
            this.uploadImg_btn.TabIndex = 0;
            this.uploadImg_btn.Text = "Display/Upload/Save Image";
            this.uploadImg_btn.UseVisualStyleBackColor = false;
            this.uploadImg_btn.Click += new System.EventHandler(this.uploadImg_Click);
            // 
            // imgDisplay_picBox
            // 
            this.imgDisplay_picBox.Location = new System.Drawing.Point(26, 27);
            this.imgDisplay_picBox.Name = "imgDisplay_picBox";
            this.imgDisplay_picBox.Size = new System.Drawing.Size(583, 434);
            this.imgDisplay_picBox.TabIndex = 1;
            this.imgDisplay_picBox.TabStop = false;
            // 
            // saveAsName_txtBox
            // 
            this.saveAsName_txtBox.Location = new System.Drawing.Point(868, 574);
            this.saveAsName_txtBox.Name = "saveAsName_txtBox";
            this.saveAsName_txtBox.Size = new System.Drawing.Size(234, 31);
            this.saveAsName_txtBox.TabIndex = 2;
            // 
            // saveAs_lbl
            // 
            this.saveAs_lbl.AutoSize = true;
            this.saveAs_lbl.Location = new System.Drawing.Point(863, 546);
            this.saveAs_lbl.Name = "saveAs_lbl";
            this.saveAs_lbl.Size = new System.Drawing.Size(98, 25);
            this.saveAs_lbl.TabIndex = 3;
            this.saveAs_lbl.Text = "Save As:";
            // 
            // jpg_checkBx
            // 
            this.jpg_checkBx.AutoSize = true;
            this.jpg_checkBx.Checked = true;
            this.jpg_checkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jpg_checkBx.Location = new System.Drawing.Point(868, 625);
            this.jpg_checkBx.Name = "jpg_checkBx";
            this.jpg_checkBx.Size = new System.Drawing.Size(91, 29);
            this.jpg_checkBx.TabIndex = 4;
            this.jpg_checkBx.Text = ".JPG";
            this.jpg_checkBx.UseVisualStyleBackColor = true;
            // 
            // getImgFile_btn
            // 
            this.getImgFile_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.getImgFile_btn.Location = new System.Drawing.Point(639, 385);
            this.getImgFile_btn.Name = "getImgFile_btn";
            this.getImgFile_btn.Size = new System.Drawing.Size(146, 51);
            this.getImgFile_btn.TabIndex = 5;
            this.getImgFile_btn.Text = "Open Folder";
            this.getImgFile_btn.UseVisualStyleBackColor = false;
            this.getImgFile_btn.Click += new System.EventHandler(this.getImgFile_btn_Click);
            // 
            // fileName_txtBx
            // 
            this.fileName_txtBx.Location = new System.Drawing.Point(644, 477);
            this.fileName_txtBx.Name = "fileName_txtBx";
            this.fileName_txtBx.Size = new System.Drawing.Size(458, 31);
            this.fileName_txtBx.TabIndex = 6;
            // 
            // fileNameTestImg_lbl
            // 
            this.fileNameTestImg_lbl.AutoSize = true;
            this.fileNameTestImg_lbl.Location = new System.Drawing.Point(639, 449);
            this.fileNameTestImg_lbl.Name = "fileNameTestImg_lbl";
            this.fileNameTestImg_lbl.Size = new System.Drawing.Size(235, 25);
            this.fileNameTestImg_lbl.TabIndex = 7;
            this.fileNameTestImg_lbl.Text = "Filename of test image:";
            // 
            // username_txtBx
            // 
            this.username_txtBx.Location = new System.Drawing.Point(765, 27);
            this.username_txtBx.Name = "username_txtBx";
            this.username_txtBx.Size = new System.Drawing.Size(150, 31);
            this.username_txtBx.TabIndex = 8;
            this.username_txtBx.Text = "alu@ioeducation.com";
            // 
            // password_txtBx
            // 
            this.password_txtBx.Location = new System.Drawing.Point(765, 73);
            this.password_txtBx.Name = "password_txtBx";
            this.password_txtBx.PasswordChar = '*';
            this.password_txtBx.Size = new System.Drawing.Size(150, 31);
            this.password_txtBx.TabIndex = 9;
            this.password_txtBx.Text = "red324";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(634, 30);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(116, 25);
            this.username_lbl.TabIndex = 10;
            this.username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(638, 76);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(112, 25);
            this.password_lbl.TabIndex = 11;
            this.password_lbl.Text = "Password:";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_btn.Location = new System.Drawing.Point(765, 122);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(253, 43);
            this.login_btn.TabIndex = 12;
            this.login_btn.Text = "Login and get Token";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // token_txtBx
            // 
            this.token_txtBx.Location = new System.Drawing.Point(26, 537);
            this.token_txtBx.Multiline = true;
            this.token_txtBx.Name = "token_txtBx";
            this.token_txtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.token_txtBx.Size = new System.Drawing.Size(773, 265);
            this.token_txtBx.TabIndex = 14;
            // 
            // token_lbl
            // 
            this.token_lbl.AutoSize = true;
            this.token_lbl.Location = new System.Drawing.Point(21, 509);
            this.token_lbl.Name = "token_lbl";
            this.token_lbl.Size = new System.Drawing.Size(71, 25);
            this.token_lbl.TabIndex = 13;
            this.token_lbl.Text = "token:";
            // 
            // saveImg_progressBar
            // 
            this.saveImg_progressBar.Location = new System.Drawing.Point(26, 467);
            this.saveImg_progressBar.Name = "saveImg_progressBar";
            this.saveImg_progressBar.Size = new System.Drawing.Size(583, 31);
            this.saveImg_progressBar.TabIndex = 15;
            // 
            // organizationId_txtBx
            // 
            this.organizationId_txtBx.Location = new System.Drawing.Point(639, 216);
            this.organizationId_txtBx.Name = "organizationId_txtBx";
            this.organizationId_txtBx.Size = new System.Drawing.Size(154, 31);
            this.organizationId_txtBx.TabIndex = 16;
            this.organizationId_txtBx.Text = "113";
            this.organizationId_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // testConfigId_txtBx
            // 
            this.testConfigId_txtBx.Location = new System.Drawing.Point(639, 265);
            this.testConfigId_txtBx.Name = "testConfigId_txtBx";
            this.testConfigId_txtBx.Size = new System.Drawing.Size(154, 31);
            this.testConfigId_txtBx.TabIndex = 17;
            this.testConfigId_txtBx.Text = "1";
            this.testConfigId_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // version_txtBx
            // 
            this.version_txtBx.Location = new System.Drawing.Point(639, 315);
            this.version_txtBx.Name = "version_txtBx";
            this.version_txtBx.Size = new System.Drawing.Size(154, 31);
            this.version_txtBx.TabIndex = 18;
            this.version_txtBx.Text = "1";
            this.version_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // studentId_txtBx
            // 
            this.studentId_txtBx.Location = new System.Drawing.Point(849, 216);
            this.studentId_txtBx.Name = "studentId_txtBx";
            this.studentId_txtBx.Size = new System.Drawing.Size(154, 31);
            this.studentId_txtBx.TabIndex = 19;
            this.studentId_txtBx.Text = "1";
            this.studentId_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // page_txtBx
            // 
            this.page_txtBx.Location = new System.Drawing.Point(849, 270);
            this.page_txtBx.Name = "page_txtBx";
            this.page_txtBx.Size = new System.Drawing.Size(154, 31);
            this.page_txtBx.TabIndex = 20;
            this.page_txtBx.Text = "1";
            this.page_txtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntOnly_KeyPress);
            // 
            // fillOut_lbl
            // 
            this.fillOut_lbl.AutoSize = true;
            this.fillOut_lbl.Location = new System.Drawing.Point(639, 185);
            this.fillOut_lbl.Name = "fillOut_lbl";
            this.fillOut_lbl.Size = new System.Drawing.Size(398, 25);
            this.fillOut_lbl.TabIndex = 21;
            this.fillOut_lbl.Text = "Fill out the following: (use numbers only)";
            // 
            // urlPost_txtBx
            // 
            this.urlPost_txtBx.Location = new System.Drawing.Point(26, 846);
            this.urlPost_txtBx.Name = "urlPost_txtBx";
            this.urlPost_txtBx.Size = new System.Drawing.Size(865, 31);
            this.urlPost_txtBx.TabIndex = 22;
            // 
            // download_btn
            // 
            this.download_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.download_btn.Location = new System.Drawing.Point(910, 834);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(192, 54);
            this.download_btn.TabIndex = 23;
            this.download_btn.Text = "Download Image";
            this.download_btn.UseVisualStyleBackColor = false;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // testImgUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 984);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.urlPost_txtBx);
            this.Controls.Add(this.fillOut_lbl);
            this.Controls.Add(this.page_txtBx);
            this.Controls.Add(this.studentId_txtBx);
            this.Controls.Add(this.version_txtBx);
            this.Controls.Add(this.testConfigId_txtBx);
            this.Controls.Add(this.organizationId_txtBx);
            this.Controls.Add(this.saveImg_progressBar);
            this.Controls.Add(this.token_txtBx);
            this.Controls.Add(this.token_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.password_txtBx);
            this.Controls.Add(this.username_txtBx);
            this.Controls.Add(this.fileNameTestImg_lbl);
            this.Controls.Add(this.fileName_txtBx);
            this.Controls.Add(this.getImgFile_btn);
            this.Controls.Add(this.jpg_checkBx);
            this.Controls.Add(this.saveAs_lbl);
            this.Controls.Add(this.saveAsName_txtBox);
            this.Controls.Add(this.imgDisplay_picBox);
            this.Controls.Add(this.uploadImg_btn);
            this.Name = "testImgUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Image";
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay_picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadImg_btn;
        private System.Windows.Forms.PictureBox imgDisplay_picBox;
        private System.Windows.Forms.TextBox saveAsName_txtBox;
        private System.Windows.Forms.Label saveAs_lbl;
        private System.Windows.Forms.CheckBox jpg_checkBx;
        private System.Windows.Forms.Button getImgFile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileName_txtBx;
        private System.Windows.Forms.Label fileNameTestImg_lbl;
        private System.Windows.Forms.TextBox username_txtBx;
        private System.Windows.Forms.TextBox password_txtBx;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox token_txtBx;
        private System.Windows.Forms.Label token_lbl;
        private System.Windows.Forms.ProgressBar saveImg_progressBar;
        private System.Windows.Forms.TextBox organizationId_txtBx;
        private System.Windows.Forms.TextBox testConfigId_txtBx;
        private System.Windows.Forms.TextBox version_txtBx;
        private System.Windows.Forms.TextBox studentId_txtBx;
        private System.Windows.Forms.TextBox page_txtBx;
        private System.Windows.Forms.Label fillOut_lbl;
        private System.Windows.Forms.TextBox urlPost_txtBx;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

