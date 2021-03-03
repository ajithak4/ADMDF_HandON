using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox1.Text);
                        int num2 = int.Parse(textBox2.Text);

                        int result = num1 + num2;

                        MessageBox.Show("Addition result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("fill both");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" enter valid details");
                }
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox1.Text);
                        int num2 = int.Parse(textBox2.Text);

                        int result = num1 - num2;

                        MessageBox.Show("Subtraction result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("fill both");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" enter valid details");
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        int num1 = int.Parse(textBox1.Text);
                        int num2 = int.Parse(textBox2.Text);

                        int result = num1 * num2;

                        MessageBox.Show("Multiplication result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("fill both");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" enter valid details");
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                try
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        double num1 = double.Parse(textBox1.Text);
                        double num2 = double.Parse(textBox2.Text);

                        double result = num1 / num2;
                        MessageBox.Show("Division result is: " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show(" fill both ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" enter valid details");
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

		
	}
}
