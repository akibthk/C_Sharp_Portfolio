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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear textbox1, clear label4, clear label5, and set focus on textbox1
            textBox1.Text = "";
            label4.Text = "";
            label5.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variable declaration
            Double length;
            Double area;
            Double perimeter;
            length = Convert.ToDouble (textBox1.Text);
            area = length * length;
            perimeter = 4 * length;
            label4.Text = area.ToString();
            label5.Text = perimeter.ToString();
        }
    }
}
