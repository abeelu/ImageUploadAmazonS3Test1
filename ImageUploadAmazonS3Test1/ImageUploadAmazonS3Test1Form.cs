using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string filename = fileName_txtBx.Text; //@"C:\Users\alu\Desktop\testingImages\grumpyCat.jpg";
            string saveNameAs = saveAsName_txtBox.Text;
            string endImgTag = "";
            
            //System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            Bitmap bmp = new Bitmap(filename);
            imgDisplay_picBox.Image = bmp;

            filename = filename.Remove(filename.LastIndexOf('\\'));

            if(jpg_checkBx.Checked)
            {
                endImgTag = ".jpg";
            }
            
            bmp.Save( filename + "\\" + saveNameAs + endImgTag);
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
                }
                catch(Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is: " + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    fileOpened = false;
                }
                Invalidate(); // what?
                
            }

            // Cancel pressed
            else if(result == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
