using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF ";

            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
				label1.Text = openFileDialog1.FileName;
               pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        
		private void button2_Click(object sender, EventArgs e)
		{
            Application.Exit();
        }

		
	}
}

