using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_usage_2
{
    public partial class Form1 : Form
    {
         public Form1() {

            InitializeComponent();
            
        }
        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("new.txt"))
            {
                string content = reader.ReadToEnd(); count = content.Length; Thread.Sleep(5000);
            } return count;
        }

        private async void btnProcessFile(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            label1.Text = "Processing File. Please Wait...";
            int count = await task;
            label1.Text = count.ToString() + " characters in file.";
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
