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
            this.username_txtBx = new System.Windows.Forms.TextBox();
            this.password_txtBx = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.token_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplay_picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImg_btn
            // 
            this.openImg_btn.Location = new System.Drawing.Point(706, 685);
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
            this.imgDisplay_picBox.Size = new System.Drawing.Size(587, 468);
            this.imgDisplay_picBox.TabIndex = 1;
            this.imgDisplay_picBox.TabStop = false;
            // 
            // saveAsName_txtBox
            // 
            this.saveAsName_txtBox.Location = new System.Drawing.Point(706, 576);
            this.saveAsName_txtBox.Name = "saveAsName_txtBox";
            this.saveAsName_txtBox.Size = new System.Drawing.Size(234, 31);
            this.saveAsName_txtBox.TabIndex = 2;
            // 
            // saveAs_lbl
            // 
            this.saveAs_lbl.AutoSize = true;
            this.saveAs_lbl.Location = new System.Drawing.Point(706, 545);
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
            this.jpg_checkBx.Location = new System.Drawing.Point(720, 630);
            this.jpg_checkBx.Name = "jpg_checkBx";
            this.jpg_checkBx.Size = new System.Drawing.Size(91, 29);
            this.jpg_checkBx.TabIndex = 4;
            this.jpg_checkBx.Text = ".JPG";
            this.jpg_checkBx.UseVisualStyleBackColor = true;
            // 
            // getImgFile_btn
            // 
            this.getImgFile_btn.Location = new System.Drawing.Point(706, 340);
            this.getImgFile_btn.Name = "getImgFile_btn";
            this.getImgFile_btn.Size = new System.Drawing.Size(251, 74);
            this.getImgFile_btn.TabIndex = 5;
            this.getImgFile_btn.Text = "Open Finder (Which image is being tested?)";
            this.getImgFile_btn.UseVisualStyleBackColor = true;
            this.getImgFile_btn.Click += new System.EventHandler(this.getImgFile_btn_Click);
            // 
            // fileName_txtBx
            // 
            this.fileName_txtBx.Location = new System.Drawing.Point(644, 464);
            this.fileName_txtBx.Name = "fileName_txtBx";
            this.fileName_txtBx.Size = new System.Drawing.Size(425, 31);
            this.fileName_txtBx.TabIndex = 6;
            // 
            // fileNameTestImg_lbl
            // 
            this.fileNameTestImg_lbl.AutoSize = true;
            this.fileNameTestImg_lbl.Location = new System.Drawing.Point(706, 436);
            this.fileNameTestImg_lbl.Name = "fileNameTestImg_lbl";
            this.fileNameTestImg_lbl.Size = new System.Drawing.Size(229, 25);
            this.fileNameTestImg_lbl.TabIndex = 7;
            this.fileNameTestImg_lbl.Text = "Filename of test image";
            // 
            // username_txtBx
            // 
            this.username_txtBx.Location = new System.Drawing.Point(760, 77);
            this.username_txtBx.Name = "username_txtBx";
            this.username_txtBx.Size = new System.Drawing.Size(192, 31);
            this.username_txtBx.TabIndex = 8;
            // 
            // password_txtBx
            // 
            this.password_txtBx.Location = new System.Drawing.Point(760, 151);
            this.password_txtBx.Name = "password_txtBx";
            this.password_txtBx.Size = new System.Drawing.Size(192, 31);
            this.password_txtBx.TabIndex = 9;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(629, 80);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(116, 25);
            this.username_lbl.TabIndex = 10;
            this.username_lbl.Text = "Username:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(634, 154);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(112, 25);
            this.password_lbl.TabIndex = 11;
            this.password_lbl.Text = "Password:";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(760, 220);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(155, 61);
            this.login_btn.TabIndex = 12;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // token_lbl
            // 
            this.token_lbl.AutoSize = true;
            this.token_lbl.Location = new System.Drawing.Point(41, 545);
            this.token_lbl.Name = "token_lbl";
            this.token_lbl.Size = new System.Drawing.Size(71, 25);
            this.token_lbl.TabIndex = 13;
            this.token_lbl.Text = "token:";
            // 
            // testImgUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 814);
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
        private System.Windows.Forms.TextBox username_txtBx;
        private System.Windows.Forms.TextBox password_txtBx;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label token_lbl;
    }
}

