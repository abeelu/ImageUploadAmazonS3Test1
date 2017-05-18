using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;


namespace ImageUploadAmazonS3Test1
{
    public partial class testImgUpload : Form
    {
        public testImgUpload()
        {
            InitializeComponent();
        }

        private void openImg_Click(object sender, EventArgs e)
        {
            saveImg_progressBar.Value = 0;
            string filename = fileName_txtBx.Text; //@"C:\Users\alu\Desktop\testingImages\grumpyCat.jpg";
            string saveNameAs = saveAsName_txtBox.Text;
            string endImgTag = "";
            
            //System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            Bitmap bmp = new Bitmap(filename);
            //imgDisplay_picBox.Image = bmp;

            filename = filename.Remove(filename.LastIndexOf('\\'));

            if(jpg_checkBx.Checked)
            {
                endImgTag = ".jpg";
            }
            
            bmp.Save( filename + "\\" + saveNameAs + endImgTag);
            saveImg_progressBar.Value = 100;
        }

        private void getImgFile_btn_Click(object sender, EventArgs e)
        {
            string openFileName = "";
            bool fileOpened;
            // Display the openFile dialog
            DialogResult result = openFileDialog1.ShowDialog();

            // OK pressed
            if(result == DialogResult.OK)
            {
                openFileName = openFileDialog1.FileName;
                try
                {
                    // output to fileName_txtBx
                    fileName_txtBx.Text = openFileName;
                    fileOpened = true;

                    Bitmap bmp = new Bitmap(openFileName);
                    imgDisplay_picBox.Image = bmp;
                    saveImg_progressBar.Width = bmp.Width;
                }
                catch(Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is: " + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    fileOpened = false;
                }
                Invalidate(); // what?
                
            }

            // Cancel pressed hello
            else if(result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string userName = username_txtBx.Text;
            string userPassword = password_txtBx.Text;

            var token = AuthenticationS3.GetBearerAsync(new Uri("https://eadmsapps.com/auth/token"), AuthenticationS3.BuildClientCredentialsRequestBody("F1494579-AB46-4528-B5CB-DE63D754560F", "7X4X885JQbDQUEpL")).Result;

            token_txtBx.Text = "Token: " + token;       

        }       
    }
}
