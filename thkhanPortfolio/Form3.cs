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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 nextform = new Form4();
            nextform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 nextform = new Form5();
            nextform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 nextform = new Form6();
            nextform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 nextform = new Form7();
            nextform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 nextform = new Form8();
            nextform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 nextform = new Form9();
            nextform.Show();
        }
    }
}
