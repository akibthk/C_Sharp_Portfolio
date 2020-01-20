using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thkhanPortfolio
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            string output = "";
            if (Convert.ToDouble(textBox1.Text) <= 0)
            {
                MessageBox.Show("Insert a positive number");
            }
            else
            {
                try
                {
                    int input = Convert.ToInt32(textBox1.Text);
                    while (input != 0)
                    {
                        int r = input % 2;
                        output += r.ToString();
                        input = input / 2;
                    }
                    for (int i = output.Length - 1; i >= 0; i--)
                    {
                        label3.Text += output[i];
                    }
                }
                catch { }
                if (output == "")
                {
                    MessageBox.Show("Input error");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
