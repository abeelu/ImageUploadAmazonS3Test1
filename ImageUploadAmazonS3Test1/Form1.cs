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
            string filename = @"C:\Users\alu\Desktop\keepCalm.png";
            //System.IO.StreamReader sr = new System.IO.StreamReader(filename);
            Bitmap bit = new Bitmap(filename);
            imgDisplayPicBox.Image = bit;
        }
    }
}
