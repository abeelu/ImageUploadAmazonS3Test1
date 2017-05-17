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
            this.openImg = new System.Windows.Forms.Button();
            this.imgDisplayPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openImg
            // 
            this.openImg.Location = new System.Drawing.Point(915, 623);
            this.openImg.Name = "openImg";
            this.openImg.Size = new System.Drawing.Size(135, 73);
            this.openImg.TabIndex = 0;
            this.openImg.Text = "Open Image";
            this.openImg.UseVisualStyleBackColor = true;
            this.openImg.Click += new System.EventHandler(this.openImg_Click);
            // 
            // imgDisplayPicBox
            // 
            this.imgDisplayPicBox.Location = new System.Drawing.Point(12, 12);
            this.imgDisplayPicBox.Name = "imgDisplayPicBox";
            this.imgDisplayPicBox.Size = new System.Drawing.Size(811, 1102);
            this.imgDisplayPicBox.TabIndex = 1;
            this.imgDisplayPicBox.TabStop = false;
            // 
            // testImgUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 1206);
            this.Controls.Add(this.imgDisplayPicBox);
            this.Controls.Add(this.openImg);
            this.Name = "testImgUpload";
            this.Text = "Upload Image";
            ((System.ComponentModel.ISupportInitialize)(this.imgDisplayPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openImg;
        private System.Windows.Forms.PictureBox imgDisplayPicBox;
    }
}

