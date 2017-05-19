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
using System.Net.Http;
using System.IO;
using System.Configuration;

namespace ImageUploadAmazonS3Test1
{
    public partial class testImgUpload : Form
    {
        public testImgUpload()
        {
            InitializeComponent();
        }

        private void uploadImg_Click(object sender, EventArgs e)
        {
            saveImg_progressBar.Value = 0;
            string filename = fileName_txtBx.Text; //@"C:\Users\alu\Desktop\testingImages\grumpyCat.jpg";           
            string saveNameAs = saveAsName_txtBox.Text;
            string endImgTag = "";
            
            //System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            Bitmap bmp = new Bitmap(filename);
            //imgDisplay_picBox.Image = bmp;

            //to change file name
            string shortenFilename = filename.Remove(filename.LastIndexOf('\\'));

            if(jpg_checkBx.Checked)
            {
                endImgTag = ".jpg";
            }
            
            //save file
            //bmp.Save(shortenFilename + "\\" + saveNameAs + endImgTag);
            //saveImg_progressBar.Value = 100;

            //upload using HttpClient
            UploadFile(filename);
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

            //var token = AuthenticationS3.GetBearerAsync(new Uri("https://eadmsapps.com/auth/token"), AuthenticationS3.BuildClientCredentialsRequestBody("AD40AC32-320D-4DFC-9C09-8E7A1D0CA3C3", "veraFQrJN4YgbPbC")).Result;
            var token = AuthenticationS3.GetBearerAsync(new Uri("https://eadmsapps.com/auth/beta/token"), AuthenticationS3.BuildResourceOwnerRequestBody("AD40AC32-320D-4DFC-9C09-8E7A1D0CA3C3", "veraFQrJN4YgbPbC", userName, userPassword)).Result;

            token_txtBx.Text = token;       

        }

        private async void UploadFile(string filename)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var access_token = token_txtBx.Text; // check if this works

                    //client.BaseAddress = new Uri("https://eadmsapps.com/api/saving-scansheet-screenshots");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                    using (var content = new MultipartFormDataContent())
                    {
                        FileStream streamFile = File.OpenRead(filename);
                        var streamContent = new StreamContent(streamFile);
                        content.Add(streamContent, "grumpyCat.jpg", filename);

                        var url = $"https://eadmsapps.com/api/saving-scansheet-screenshots/scansheetimages/{organizationId_txtBx.Text}/{testConfigId_txtBx.Text}/{version_txtBx.Text}/{studentId_txtBx.Text}/{page_txtBx.Text}";
                        var result = await client.PostAsync(url, content);
                        result.EnsureSuccessStatusCode();
                        urlPost_txtBx.Text = result.Headers.GetValues("location").FirstOrDefault();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void IntOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private async void download_btn_Click(object sender, EventArgs e)
        {
            string saveFileName = "";
            bool fileOpened;
            // Display the openFile dialog
            DialogResult resultSave = saveFileDialog1.ShowDialog();

            //if ok pressed
            if (resultSave == DialogResult.OK)
            {
                saveFileName = saveFileDialog1.FileName;
                try
                {
                    fileOpened = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is: " + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    fileOpened = false;
                }
                Invalidate();
            }
             // Cancel pressed hello
            else if (resultSave == DialogResult.Cancel)
            {
                return;
            }
            
            try
            {                
                using (var client = new HttpClient())
                {
                    var access_token = token_txtBx.Text; // check if this works

                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + access_token);
                    using (var content = new MultipartFormDataContent())
                    {
                        var result = await client.GetAsync(urlPost_txtBx.Text);
                        result.EnsureSuccessStatusCode();

                        System.IO.File.WriteAllBytes(saveFileDialog1.FileName, await result.Content.ReadAsByteArrayAsync());
                        
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
