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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear textbox1, clear textbox2, clear label4, and set focus on textbox1
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variable declaration
            Double currentyear;
            Double birthyear;
            Double age;
            currentyear = Convert.ToDouble (textBox1.Text);
            birthyear = Convert.ToDouble (textBox2.Text);
            age = currentyear - birthyear;
            label4.Text = age.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
