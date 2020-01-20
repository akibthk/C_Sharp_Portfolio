using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thkhanproject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear textbox1, clear label3, and set focus on textbox1
            textBox1.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Hello " + textBox1.Text + "!";
            this.Text = label3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
